using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
//using

namespace SDC
{

    public abstract class SDCTreeBuilder : ITreeBuilder
    {
        #region  Static Methods

        #endregion

        #region  Local Fields
        protected DataTable dtFormDesign { get; set; }
        protected DataTable dtHeaderDesign { get; set; }
        protected DataRow drFormDesign { get; set; }
        protected decimal Order { get; set; }

        //!raise event when form is created, so it can be serialized and/or transformed
        public decimal FormDesignID { get; set; } //CTV_Ckey
        public string XsltFileName { get; set; }


        public FormDesignType FormDesign { get; set; }
        #endregion

        #region Ctor
        public SDCTreeBuilder() //TreeBuilder.Ecc is the class that subclasses this abstract class
        //!We can initialize dtFormDesign here - can pass initializer into the constructor, also can pass in FormDesignID
        {   //Can (partially) initialize FormDesign data source here, using overloaded constructor in subclass
            //Initialize FormDesign, FormDesignID, xslt
            Order = 0;
        }
        //internal abstract SDCTreeBuilder(string formDesignID, IFormDesignDataSets dataSets, string xsltPath = "");
        #endregion

        #region  Template Builder

        public abstract ItemTypeEnum GetEccRowTypeEnum(string strRowType);
        public abstract QuestionEnum GetEccQuestionTypeEnum(string strRowType);
        internal abstract SectionEnum GetSectionType(string strSectionType);
        internal abstract void InitRow(out ItemTypeEnum rowType, out string parentID, out string type);
        //protected internal abstract SectionItemType AddHeader(SectionItemType header);
        //protected internal abstract SectionItemType AddFooter(SectionItemType footer);

        /// <summary>
        /// //make sure FormDesign has injected and primed ITreeBuilder and IFormDesignDataSet objects
        /// </summary>
        /// <returns></returns>
        public virtual FormDesignType CreateFormDesignTree()
        {

            var rowType = new ItemTypeEnum();
            var qType = new QuestionEnum();
            string type = string.Empty;
            BaseType parentNode = null;
            IdentifiedExtensionType prevSibNode;

            FormDesign.ID = FormDesignID.ToString();
            FormDesign.baseURI = "www.cap.org/eCC/SDC/IHE";
            DisplayedType di;
            QuestionItemType qi;
            ListItemType li;
            SectionItemType si;



            string parURI;
            //for (int i = 0; i < dtFormDesign.Rows.Count - 1; i++)
            foreach (DataRow dr in dtFormDesign.Rows)
            {
                drFormDesign = dr;   //dtFormDesign.Rows[i];
                //BuildFormDesignTree();
                InitRow(out rowType, out parURI, out type);

                parentNode = null; di = null; qi = null;
                li = null; si = null;
                //Debug.WriteLine(rowType.ToString() + ":" + drFormDesign["VisibleText"].ToString() + drFormDesign["ChecklistTemplateItemCkey"].ToString());
                switch (rowType)
                {
                    case ItemTypeEnum.FormDesign:
                        throw new NotImplementedException();  //TODO: decide whether to keep this
                        break;
                    case ItemTypeEnum.ListItemFillin:
                    case ItemTypeEnum.ListItem:
                        qi = (QuestionItemType)SDCHelpers.GetParentItem(parURI);
                        li = AddFillListItemToQuestion(qi);
                        if (li != null) IdentifiedExtensionType.IdentExtNodes.Add(li.ID, li);
                        break;
                    case ItemTypeEnum.QuestionFill:
                    case ItemTypeEnum.QuestionLookup:
                    case ItemTypeEnum.QuestionMultiple:
                    case ItemTypeEnum.QuestionSingle:
                    case ItemTypeEnum.QuestionGroup:
                        qType = (QuestionEnum)rowType;  //The more restrictive QuestionEnum is needed fopr AddQuestion below; The 2 Enum types share question enum values
                        parentNode = SDCHelpers.GetParentItem(parURI);
                        if (parentNode == null)
                        {
                            var body = FormDesign.AddBody();
                            if (body.ID == null) body.ID = FormDesignID + "_DefaultBodyGUID_" + Guid.NewGuid(); //Set a default ID, in case the database template does not have a body
                            qi = body.AddFillQuestion(qType);
                        }
                        else
                            switch (parentNode.NodeType)
                            {
                                case ItemTypeEnum.Header:
                                case ItemTypeEnum.Body:
                                case ItemTypeEnum.Footer:
                                case ItemTypeEnum.Section:
                                case ItemTypeEnum.SectionGroup:
                                    qi = AddFillQuestion<SectionItemType>((SectionItemType)parentNode, qType);
                                    break;
                                case ItemTypeEnum.ListItemFillin:
                                case ItemTypeEnum.ListItem:
                                    qi = AddFillQuestion<ListItemType>((ListItemType)parentNode, qType);
                                    break;
                                case ItemTypeEnum.QuestionFill:
                                case ItemTypeEnum.QuestionLookup:
                                case ItemTypeEnum.QuestionMultiple:
                                case ItemTypeEnum.QuestionSingle:
                                case ItemTypeEnum.QuestionGroup:
                                    qi = AddFillQuestion<QuestionItemType>((QuestionItemType)parentNode, qType);
                                    break;
                                default:
                                    //illegal parent for the question, so add it to the main Body section where it will be in an obviously wrong position
                                    qi = AddFillQuestion<SectionItemType>(FormDesign.Body, qType);
                                    var ot = qi.AddFillProperty(false);
                                    ot.val = "ERROR: This Question child node has a " + parentNode.NodeType.ToString() + " as a parent, but this parent type cannot have child nodes in SDC.  The child node was placed under the main Body node instead, and the order attribute may not be in the correct sequence: ";

                                    break;
                            }
                        if (qi != null) IdentifiedExtensionType.IdentExtNodes.Add(qi.ID, qi);
                        break;
                    case ItemTypeEnum.Header:
                    case ItemTypeEnum.Body:
                    case ItemTypeEnum.Footer:
                    case ItemTypeEnum.Section:
                    case ItemTypeEnum.SectionGroup:
                        parentNode = SDCHelpers.GetParentItem(parURI);

                        if (parentNode == null)
                            switch (rowType)
                            {
                                case ItemTypeEnum.Header:
                                    if (FormDesign.Header == null) si = FormDesign.AddHeader(true);
                                    else si = FormDesign.Header.AddFillSection();  //add multiple headers under main Header
                                    break;
                                case ItemTypeEnum.Footer:
                                    if (FormDesign.Footer == null) si = FormDesign.AddFooter(true);
                                    else si = FormDesign.Footer.AddFillSection(); //add multiple footers under main Footer
                                    break;
                                case ItemTypeEnum.Body:
                                    if (FormDesign.Body == null) si = FormDesign.AddBody(true);
                                    else si = FormDesign.Body.AddFillSection();  //can add multiple Body sections under main Body

                                    break;
                                case ItemTypeEnum.Section:
                                case ItemTypeEnum.SectionGroup:
                                default: //a top-level section (one with no parent) must be a child of Body
                                    SectionItemType body;

                                    if (FormDesign.Body == null)
                                    {
                                        body = FormDesign.AddBody(); //create a body (parent) to hold the new sections
                                        body.ID = FormDesignID + "_DefaultBodyGUID_" + Guid.NewGuid(); //Set a default ID, in case the database template does not have a body
                                    }
                                    else body = FormDesign.Body;

                                    si = body.AddFillSection(); //add new section to the body node
                                    break;
                            }
                        else
                            switch (parentNode.NodeType)
                            {
                                case ItemTypeEnum.Header:
                                case ItemTypeEnum.Body:
                                case ItemTypeEnum.Footer:
                                case ItemTypeEnum.Section:
                                case ItemTypeEnum.SectionGroup:
                                    si = AddFillSection<SectionItemType>((SectionItemType)parentNode);
                                    break;
                                case ItemTypeEnum.ListItemFillin:
                                case ItemTypeEnum.ListItem:
                                    si = AddFillSection<ListItemType>((ListItemType)parentNode);
                                    break;
                                case ItemTypeEnum.QuestionFill:
                                case ItemTypeEnum.QuestionLookup:
                                case ItemTypeEnum.QuestionMultiple:
                                case ItemTypeEnum.QuestionSingle:
                                case ItemTypeEnum.QuestionGroup:
                                    si = AddFillSection<QuestionItemType>((QuestionItemType)parentNode);
                                    break;
                                default:
                                    //illegal parent for the section (e.g., a DisplayedItem), so add it to the main Body section where it will be in an obviously wrong position
                                    //!This will also cause the elements to be out of order.
                                    si = AddFillSection<SectionItemType>(FormDesign.Body);
                                    var ot = si.AddFillProperty(false);
                                    ot.val = "ERROR: This Section child node has a " + parentNode.NodeType.ToString() + " as a parent, but this parent type cannot have child nodes in SDC.  The child node was placed under the main Body node instead, and the order attribute may not be in the correct sequence: ";
                                    break;
                            }

                        if (si != null) IdentifiedExtensionType.IdentExtNodes.Add(si.ID, si);
                        break;
                    case ItemTypeEnum.DisplayedItem:
                        parentNode = SDCHelpers.GetParentItem(parURI);

                        if (parentNode == null)
                        {
                            SectionItemType body;
                            if (FormDesign.Body == null)
                            {
                                body = FormDesign.AddBody();
                                body.ID = FormDesignID + "_DefaultBodyGUID_" + Guid.NewGuid(); //Set a default ID, in case the database template does not have a body
                            }
                            else body = FormDesign.Body;

                            di = FormDesign.Body.AddFillDisplayedItem();
                        }
                        else
                            switch (parentNode.NodeType)
                            {
                                case ItemTypeEnum.Header:
                                case ItemTypeEnum.Body:
                                case ItemTypeEnum.Footer:
                                case ItemTypeEnum.Section:
                                case ItemTypeEnum.SectionGroup:
                                    di = AddFillDisplayedItem<SectionItemType>((SectionItemType)parentNode);
                                    break;
                                case ItemTypeEnum.ListItemFillin:
                                case ItemTypeEnum.ListItem:
                                    di = AddFillDisplayedItem<ListItemType>((ListItemType)parentNode);
                                    break;
                                case ItemTypeEnum.QuestionFill:
                                case ItemTypeEnum.QuestionLookup:
                                case ItemTypeEnum.QuestionMultiple:
                                case ItemTypeEnum.QuestionSingle:
                                case ItemTypeEnum.QuestionGroup:
                                    di = AddFillDisplayedItem<QuestionItemType>((QuestionItemType)parentNode);
                                    break;
                                default:
                                    //illegal parent for the DisplayedItem, so add it to the main Body section where it will be in an obviously wrong position
                                    di = AddFillDisplayedItem<SectionItemType>(FormDesign.Body);
                                    var ot = di.AddFillProperty(false);
                                    ot.val = "ERROR: This DisplayedItem child node has a " + parentNode.NodeType.ToString() + " as a parent, but this parent type cannot have child nodes in SDC.  The child node was placed under the main Body node instead, and the order attribute may not be in the correct sequence: ";
                                    break;
                            }

                        if (di != null) IdentifiedExtensionType.IdentExtNodes.Add(di.ID, di);
                        break;
                    case ItemTypeEnum.ListNote:
                        try
                        {
                            qi = (QuestionItemType)SDCHelpers.GetParentItem(parURI);
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("The ListItem title is: ", "Error converting the parent item to a question type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            System.Diagnostics.Debug.Print(drFormDesign["ChecklistTemplateItemCkey"].ToString());
                        }
                        di = AddFillListNoteToQuestion(qi);
                        if (di != null) IdentifiedExtensionType.IdentExtNodes.Add(di.ID, di);
                        break;
                    case ItemTypeEnum.Rule:
                        throw new NotImplementedException();
                        break;
                    case ItemTypeEnum.Button:
                        throw new NotImplementedException();
                        break;
                    case ItemTypeEnum.InjectForm:
                        throw new NotImplementedException();
                        break;
                    default:
                        throw new NotImplementedException();
                        break;
                }
            }
            return FormDesign;
        }


        /// <summary>
        /// Gets template by Ckey
        /// </summary>
        /// <param name="formDesignID">Ckey of template to get</param>
        /// <param name="BESTfilename">The preferred file name.  Use USERfilename in preference to the Database supplied filename</param>
        /// <param name="USERfilename">The preferred filename, if available</param>
        /// <value>retirns FormDesign XML or "" if an error occurs</value>
        /// <returns>Template XML</returns>
        public virtual String GetTemplateByCkey(String formDesignID, out String BESTfilename, String USERfilename)
        {
            Decimal decFormDesignID = 0;
            if (formDesignID.Trim() != string.Empty && Decimal.TryParse(formDesignID, out decFormDesignID))
                if (decFormDesignID > 0)
                {
                    FormDesignID = decFormDesignID;
                    if (USERfilename == string.Empty)
                        USERfilename = "_file_" + DateTime.Now.Ticks.ToString().Trim();    //create a dummy filename and insert it into the dataset, so it's also added to the XML

                    BESTfilename = USERfilename;
                    this.CreateFormDesignTree(); //make sure FormDesign has an injected ITreeBuilder, and an injected IFormDesignDataSet

                    return SerializeFormDesignTree();
                }
            BESTfilename = "error";
            return String.Empty;
        }

        /// <summary>
        /// Creates template with information from data tables
        /// </summary>
        /// <param name="templateVersion">Data table with information about the template version</param>
        /// <param name="templateItems">Data table with information about the template items</param>
        /// <param name="templateProcedures">Data table with information about the template procedures</param>
        /// <returns>Template Xml</returns>
        public virtual String SerializeFormDesignTree()
        {
            if (FormDesign != null)
            {
                var ns = new XmlSerializerNamespaces();
                //rlm: next line directs the format of the serialized XML, according to the schema-generated template
                var serializer = new XmlSerializer(typeof(FormDesignType));
                var writer = new System.IO.StringWriter();
                serializer.Serialize(writer, FormDesign, ns);
                String formDesignXml = writer.ToString();

                //String formDesignXml = FormDesign.Serialize();
                //if (this.XsltFileName != String.Empty)
                //{
                //    //rlm: add xsl transform directive;
                //    var replaceTxt = "encoding=\"UTF-8\"?>";
                //    formDesignXml = formDesignXml.Replace(replaceTxt,
                //        string.Format(replaceTxt +
                //        "/r/n<?xml-stylesheet type=\"text/xsl\" href=\"{0}\" ?>/r/n",
                //        XsltFileName));
                //}

                // entity strings being passed thru by the serializer
                // specifically apos and quot, need to be fixed
                formDesignXml = formDesignXml.Replace("&amp;quot", "&quot");
                formDesignXml = formDesignXml.Replace("&amp;apos", "&apos");
                return formDesignXml;
            }
            return String.Empty;
        }

        public virtual SectionItemType AddFillBody(Boolean fillData = false)
        {
            if (FormDesign.Body == null)
            {
                FormDesign.Body = AddFillNewSection(FormDesign, fillData);
                //FormDesign.Body.RegisterParent(FormDesign);
                return FormDesign.Body;
            }
            else return FormDesign.Body;
        }

        public virtual SectionItemType AddFillHeader(Boolean fillData = false)
        {
            if (FormDesign.Header == null)
            {
                FormDesign.Header = AddFillNewSection(FormDesign, fillData);
                //FormDesign.Header.RegisterParent(FormDesign);
                return FormDesign.Header;
            }
            else return FormDesign.Header;
        }

        public virtual SectionItemType AddFillFooter(Boolean fillData = false)
        {
            if (FormDesign.Footer == null)
            {
                FormDesign.Footer = AddFillNewSection(FormDesign, fillData);
                //FormDesign.Footer.RegisterParent(FormDesign);
                return FormDesign.Footer;
            }
            else return FormDesign.Footer;
        }

        #endregion


        #region Base Types

        protected virtual RepeatingType AddFillRepeatingTypeItems(RepeatingType rt, Boolean fillData = true)
        {
            AddFillDisplayedTypeItems(rt, fillData);
            if (fillData) FillRepeating(rt);
            return rt;
        }
        public abstract RepeatingType FillRepeating(RepeatingType rt);

        public virtual DisplayedType AddFillDisplayedTypeItems(DisplayedType dt, Boolean fillData = true)
        {
            AddFillIdentifiedTypeItems(dt, fillData);
            if (fillData) FillDisplayedTypeItems(dt);
            return dt;

            //Each row can have multiple Property, Blobs, Contacts, Codes, Links
            //Small numbers of these can travel in the same record, but the structured will be relatively simple.
            //An ORM model will be more capable, enabling any number of each of the above items
            //at any level of complexity.
            //This model does not yet cover extensions, which can occur anywhere
            //Rules not covered here yet - may be out of scope for pilot
            //need style lists


            //string type = "";
            //TODO: tooltip, reportText, shortReportText, Description, NoteDEF, NoteReport
            //adjust for multiple OT: ShortNames, Reporting Text, instructions, footnotes, TNM short forms
            //AddProperty(dt);
            //adjust for multiple Blobs
            //AddBlob(dt);
            //adjust for multiple contacts - FIGO and AJCC?
            //AddContact(dt);
            //adjust for multiple codes
            //AddCodedValue(dt);  //TNM short forms?
            //adjust for multiple link
            //AddLink(dt);

            //return (DisplayedType)dt;
            //addDisplayedTypeToChildItems(rt);
        }
        public abstract DisplayedType FillDisplayedTypeItems(DisplayedType dt);
        protected abstract DisplayedType FillDisplayedTypeListItem(DisplayedType dt, string title, QuestionItemType qNode);

        public virtual IdentifiedExtensionType AddFillIdentifiedTypeItems(IdentifiedExtensionType ietParent, Boolean fillData = true)
        {
            AddFillExtensionBaseTypeItems(ietParent, fillData);
            if (fillData) FillIdentifiedTypeItems(ietParent);
            return ietParent;
        }
        public abstract IdentifiedExtensionType FillIdentifiedTypeItems(IdentifiedExtensionType iet);

        public virtual ExtensionBaseType AddFillExtensionBaseTypeItems(ExtensionBaseType ebt, Boolean fillData = true)
        {
            AddFillComment(ebt, fillData);
            AddFillExtension(ebt, fillData);
            AddFillBaseTypeItems(ebt, fillData);
            return ebt;
        }

        public virtual BaseType AddFillBaseTypeItems(BaseType bt, Boolean fillData = true)
        {
            if (fillData) FillBaseTypeItems(bt);

            return bt;
        }
        protected abstract BaseType FillBaseTypeItems(BaseType btParent);

        public virtual CommentType AddFillComment(ExtensionBaseType ebtParent, Boolean fillData = true, string comment = "")
        {
            if (ebtParent.Comment == null) ebtParent.Comment = new List<CommentType>();
            CommentType ct = null;
            if (fillData)
            {
                ct = FillComment(ebtParent, comment);
                ebtParent.Comment.Add(ct);  //return new empty Comment object for caller to fill
            }


            return ct;

        }
        protected abstract CommentType FillComment(BaseType bt, string comment);

        public abstract ExtensionType AddFillExtension(ExtensionBaseType ebtParent, Boolean fillData = true, string InXML = "");

        #endregion

        #region Data Types

        protected abstract FuncType AddFillWebService(LookupEndPointType lepParent, Boolean fillData = true);
        protected abstract FuncType FillWebService(FuncType wst);
        protected abstract DataTypes_SType AddFillDataTypesS(CodingType codingParent);
        protected abstract DataTypes_DEType AddFillDataTypesDE(ResponseFieldType rfParent);
        protected abstract DataTypes_DEType AddFillDataTypesDE(ListFieldType lftParent, SectionBaseTypeResponseTypeEnum dataType);

        protected virtual DataTypes_DEType AddDataTypesDE(
            ResponseFieldType rfParent,
            object value,
            ItemChoiceType dataTypeEnum = ItemChoiceType.@string,
            //DataTypes_DE_Enum dataTypeEnum = DataTypes_DE_Enum.@string;
            dtQuantEnum quantifierEnum = dtQuantEnum.EQ)
        {
            rfParent.Response = new DataTypes_DEType(rfParent);
            //rfParent.Response.RegisterParent(rfParent);
            //rfParent.Response.ItemElementName = dataTypeEnum;
            //AddFillBaseTypeItems(rfParent.Response, false);  no need to add metadata to this element

            switch (dataTypeEnum)
            {
                case ItemChoiceType.HTML:
                    {
                        var dt = new HTML_DEtype(rfParent.Response);
                        dt.Any = new List<XmlElement>();
                        dt.AnyAttr = new List<XmlAttribute>();
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.XML: //TODO: Need to be able to add custom attributes to first wrapper element - see anyType; in fact, do we even need XML as a separate type?
                    {
                        var dt = new XML_DEtype(rfParent.Response);
                        dt.Any = new List<XmlElement>();
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.anyType:
                    {
                        var dt = new anyType_DEtype(rfParent.Response);
                        dt.Any = new List<XmlElement>();
                        dt.AnyAttr = new List<XmlAttribute>();
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.anyURI:
                    {
                        var dt = new anyURI_DEtype(rfParent.Response);
                        dt.val = (string)value;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.base64Binary:
                    {
                        var dt = new base64Binary_DEtype(rfParent.Response);
                        dt.val = (byte[])value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.boolean:
                    {
                        var dt = new boolean_DEtype(rfParent.Response);
                        dt.val = (bool)value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@byte:
                    {
                        var dt = new byte_DEtype(rfParent.Response);
                        dt.val = (sbyte)value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.date:
                    {
                        var dt = new date_DEtype(rfParent.Response);
                        dt.val = (DateTime)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@dateTime: //TODO: added the "@" symbol to dateTime and dateTimeStamp here, in AddFillDataTypesDE, and in the 2 ItemChoiceType files.  Also fixed bug in the DateTypes_DEtype with the wrong ItemTypeNames from xsd2code - on dateTime and dateTimeStamp.
                    {
                        var dt = new dateTime_DEtype(rfParent.Response);
                        if (value != null)  //TODO: value testing may be needed for the other dateTime and duration types in this method, and also in AddFillDataTypesDE
                        {
                            var test = value as DateTime?;
                            if (test != null)
                                dt.val = (DateTime)test;
                            else
                                try
                                {
                                    var sTest = DateTime.Parse(value.ToString());
                                    dt.val = sTest;
                                }
                                catch (Exception ex)
                                { }
                        }
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@dateTimeStamp:
                    {
                        var dt = new dateTimeStamp_DEtype(rfParent.Response);
                        dt.val = (DateTime)value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@decimal:
                    {
                        var dt = new decimal_DEtype(rfParent.Response);
                        dt.val = (decimal)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@double:
                    {
                        var dt = new double_DEtype(rfParent.Response);
                        dt.val = (double)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.duration:
                    {
                        var dt = new duration_DEtype(rfParent.Response);
                        dt.val = (string)value;   //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        //rfParent.Response.DataTypeDE_Item = dt;
                    }
                    break;
                case ItemChoiceType.@float:
                    {
                        var dt = new float_DEtype(rfParent.Response);
                        dt.val = (float)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.gDay:
                    {
                        var dt = new gDay_DEtype(rfParent.Response);
                        dt.val = (string)value; ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.gMonth:
                    {
                        var dt = new gMonth_DEtype(rfParent.Response);
                        dt.val = (string)value; ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.gMonthDay:
                    {
                        var dt = new gMonthDay_DEtype(rfParent.Response);
                        dt.val = (string)value; ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.gYear:
                    {
                        var dt = new gYear_DEtype(rfParent.Response);
                        dt.val = (string)value; ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.gYearMonth:
                    {
                        var dt = new gYearMonth_DEtype(rfParent.Response);
                        dt.val = (string)value; //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.hexBinary:
                    {
                        var dt = new hexBinary_DEtype(rfParent.Response);
                        dt.val = (byte[])value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@int:
                    {
                        var dt = new int_DEtype(rfParent.Response);
                        dt.val = (int)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.integer:
                    {
                        var dt = new integer_DEtype(rfParent.Response);
                        dt.val = (string)value; ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@long:
                    {
                        var dt = new long_DEtype(rfParent.Response);
                        dt.val = (long)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        dt.RegisterParent(rfParent.Response);
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.negativeInteger:
                    {
                        var dt = new negativeInteger_DEtype(rfParent.Response);
                        //dt.val = drFormDesign["DefaultValue"].ToString(); ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.nonNegativeInteger:
                    {
                        var dt = new nonNegativeInteger_DEtype(rfParent.Response);
                        //dt.val = drFormDesign["DefaultValue"].ToString(); ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.nonPositiveInteger:
                    {
                        var dt = new nonPositiveInteger_DEtype(rfParent.Response);
                        //dt.val = drFormDesign["DefaultValue"].ToString(); ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.positiveInteger:
                    {
                        var dt = new positiveInteger_DEtype(rfParent.Response);
                        //dt.val = drFormDesign["DefaultValue"].ToString(); ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.@short:
                    {
                        var dt = new short_DEtype(rfParent.Response);
                        dt.val = (short)value;
                        dt.quantEnum = quantifierEnum;
                        dt.RegisterParent(rfParent.Response);
                        //rfParent.Response.DataTypeDE_Item = dt;
                    }
                    break;
                case ItemChoiceType.@string:
                    {
                        var dt = new @string_DEtype(rfParent.Response);
                        dt.val = (string)value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.time:
                    {
                        var dt = new time_DEtype(rfParent.Response);
                        dt.val = (DateTime)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.unsignedByte:
                    {
                        var dt = new unsignedByte_DEtype(rfParent.Response);
                        dt.val = (byte)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.unsignedInt:
                    {
                        var dt = new unsignedInt_DEtype(rfParent.Response);
                        dt.val = (uint)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.unsignedLong:
                    {
                        var dt = new unsignedLong_DEtype(rfParent.Response);
                        dt.val = (ulong)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.unsignedShort:
                    {
                        var dt = new unsignedShort_DEtype(rfParent.Response);
                        dt.val = (ushort)value;
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                case ItemChoiceType.yearMonthDuration:
                    {
                        var dt = new yearMonthDuration_DEtype(rfParent.Response);
                        dt.val = (String)value; ;  //TODO:  bug in xsdCode++ - wrong data type
                        dt.quantEnum = quantifierEnum;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
                default:
                    {
                        var dt = new @string_DEtype(rfParent.Response);
                        dt.val = (string)value;
                        rfParent.Response.DataTypeDE_Item = dt;
                        //dt.RegisterParent(rfParent.Response);
                    }
                    break;
            }

            rfParent.Response.ItemElementName = dataTypeEnum;
            AddFillBaseTypeItems(rfParent.Response.DataTypeDE_Item);
            return rfParent.Response;

        }



        protected virtual dtQuantEnum AssignQuantifier()
        {
            var dtQE = new dtQuantEnum();
            var q = FillQuantifier();

            switch (q)
            {
                case "EQ":
                    dtQE = dtQuantEnum.EQ;
                    break;
                case "GT":
                    dtQE = dtQuantEnum.GT;
                    break;
                case "GTE":
                    dtQE = dtQuantEnum.GTE;
                    break;
                case "LT":
                    dtQE = dtQuantEnum.LT;
                    break;
                case "LTE":
                    dtQE = dtQuantEnum.LTE;
                    break;
                case "APPROX":
                    dtQE = dtQuantEnum.APPROX;
                    break;
                case "":
                    dtQE = dtQuantEnum.EQ;
                    break;
                case null:
                    dtQE = dtQuantEnum.EQ;
                    break;
                default:
                    dtQE = dtQuantEnum.EQ;
                    break;
            }
            return dtQE;
        }
        protected abstract string FillQuantifier();

        protected virtual XmlElement StringToXMLElement(string rawXML)
        {
            var xe = XElement.Parse(rawXML, LoadOptions.PreserveWhitespace);
            var doc = new XmlDocument();

            var xmlReader = xe.CreateReader();
            doc.Load(xmlReader);
            xmlReader.Dispose();

            return doc.DocumentElement;
        }

        #endregion

        #region Contact

        #region Add Contacts


        /// <summary>
        /// Add Contact to the Contacts type inside FileType
        /// </summary>
        /// <param name="cts"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public ContactType AddFillContact(FileType ftParent, Boolean fillData = true)
        {
            ContactsType c;
            if (ftParent.Contacts == null)
                c = AddContactsListToFileType(ftParent);
                //c.RegisterParent(ftParent);
            else
                c = ftParent.Contacts;
            var ct = new ContactType(c);
            c.Contact.Add(ct);
            //ct.RegisterParent(c);
            //TODO: Need to be able to add multiple people/orgs by reading the data source or ORM
            var p = AddPerson(ct);
            //p.RegisterParent(ct);
            var org = AddFillOrganization(ct);
            //ct.RegisterParent(org);

            return ct;
        }

        public ContactType AddFillContact(DisplayedType dtParent, Boolean fillData = true)
        {
            if (dtParent.Contact == null) dtParent.Contact = new List<ContactType>();
            var ct = new ContactType(dtParent);
            dtParent.Contact.Add(ct);
            //ct.RegisterParent(dtParent);
            return ct;
        }

        /// <summary>
        /// Add a Contacts grouper to FileType; Contacts contains a List<ContactType/>
        /// </summary>
        /// <param name="ftParent"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public ContactsType AddContactsListToFileType(FileType ftParent)
        {
            if (ftParent.Contacts == null)
                ftParent.Contacts = new ContactsType(ftParent);
                //ftParent.Contacts.RegisterParent(ftParent);
                //List<ContactsType>();
            return ftParent.Contacts; //returns a .NET List<ContactType>

        }

        protected abstract ContactType FillContact(ContactType ct);

        #endregion

        #region Address
        public virtual AddressType AddFillAddress(PersonType ptParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }
        public virtual AddressType AddFillAddress(OrganizationType otParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }

        protected abstract AddressType FillAddress(AddressType at);

        #endregion

        #region Person

        public virtual PersonType AddPerson(ContactType contactParent)
        {
            //if (contactParent == null) { contactParent = new ContactType(); }

            var newPerson = new PersonType(contactParent);
            contactParent.Person = newPerson;
            //newPerson.RegisterParent(contactParent);

            AddFillPersonItems(newPerson);  //AddFillPersonItems?

            return newPerson;
        }

        public virtual PersonType AddPerson(DisplayedType dtParent)
        {
            List<ContactType> contactList;
            if (dtParent.Contact == null)
            {
                contactList = new List<ContactType>();
                dtParent.Contact = contactList;
            }
            else
                contactList = dtParent.Contact;
            var newContact = new ContactType(dtParent); //newContact will contain a person child
            contactList.Add(newContact);
            //newContact.RegisterParent(dtParent); //dtParent holds a list of type ContactType.

            var newPerson = AddPerson(newContact);

            return newPerson;
        }

        public virtual PersonType AddContactPerson(OrganizationType otParent)
        {
            List<PersonType> contactPersonList;
            if (otParent.ContactPerson == null)
            {
                contactPersonList = new List<PersonType>();
                otParent.ContactPerson = contactPersonList;
            }
            else
                contactPersonList = otParent.ContactPerson;
            var newPerson = new PersonType(otParent);
            AddFillPersonItems(newPerson);

            contactPersonList.Add(newPerson);
            //newPerson.RegisterParent(otParent);
            return newPerson;
        }


        public virtual PersonType AddFillPersonItems(PersonType pt, Boolean fillData = true)  //AddFillPersonItems, make this abstract and move to subclass?
        {
            //var dr = this.drFormDesign();
            pt.PersonName = new NameType(pt);//TODO: Need separate method(s) for this
            //pt.PersonName.RegisterParent(pt);
            //pt.Alias = new NameType();
            //pt.PersonName.FirstName.val = (string)drFormDesign["FirstName"];  //TODO: replace with real data
            //pt.PersonName.LastName.val = (string)drFormDesign["LastName"];  //TODO: replace with real data

            pt.Email = new List<EmailType>();//TODO: Need separate method(s) for this
            var email = new EmailType(pt);//TODO: Need separate method(s) for this
            pt.Email.Add(email);
            //email.RegisterParent(pt);

            pt.Phone = new List<PhoneType>();//TODO: Need separate method(s) for this
            pt.Job = new List<JobType>();//TODO: Need separate method(s) for this

            pt.Role = new string_Stype(pt);
            //pt.Role.RegisterParent(pt);

            pt.StreetAddress = new List<AddressType>();//TODO: Need separate method(s) for this
            pt.Identifier = new List<IdentifierType>();

            pt.Usage = new string_Stype(pt);
            //pt.Usage.RegisterParent(pt);

            pt.WebURL = new List<anyURI_Stype>();//TODO: Need separate method(s) for this

            return pt;
        }


        protected abstract NameType FillPersonName(PersonType pt);
        protected abstract JobType FillPersonJob(JobType pt);
        protected abstract EmailType FillPersonEmail(EmailType ot);
        protected abstract PhoneType FillPersonPhone(PhoneType ot);
        protected abstract string_Stype FillPersonUsage(string_Stype ut);
        protected abstract IdentifierType FillPersonIdentifier(IdentifierType ot);
        protected abstract string FillPersonWebURL(string ot);
        protected abstract string FillPersonAddress1(string ot);
        protected abstract string FillPersonAddress2(string ot);
        protected abstract string FillPersonAddress3(string ot);
        protected abstract string FillPersonAddress4(string ot);
        #endregion

        #region Organization

        public virtual OrganizationType AddFillOrganization(ContactType contactParent, Boolean fillData = true)
        {
            var ot = new OrganizationType(contactParent);
            contactParent.Organization = ot;
            //ot.RegisterParent(contactParent);
            if (fillData) AddFillOrganizationItems(ot);
            return ot;
        }

        public virtual OrganizationType AddFillOrganization(JobType jobParent, Boolean fillData = true)
        {
            var ot = new OrganizationType(jobParent);
            jobParent.Organization = ot;
            //ot.RegisterParent(jobParent);
            if (fillData) AddFillOrganizationItems(ot);
            return ot;
        }
        public abstract OrganizationType AddFillOrganizationItems(OrganizationType ot, Boolean fillData = true);

        protected abstract string_Stype FillOrgName(string_Stype ot);
        protected abstract string FillOrgDept(string ot);
        protected abstract string FillOrgAddress1(string ot);
        protected abstract string FillOrgAddress2(string ot);
        protected abstract string FillOrgAddress3(string ot);
        protected abstract string FillOrgAddress4(string ot);



        protected abstract NameType FillOrgName(PersonType pt);
        protected abstract string FillOrgRole(string rt);
        protected abstract EmailType FillOrgEmail(EmailType et);
        protected abstract PhoneType FillOrgPhone(PhoneType ot);
        protected abstract string FillOrgUsage(string ut);
        protected abstract IdentifierType FillOrgIdentifier(IdentifierType ot);
        protected abstract anyURI_Stype FillOrgWebURL(anyURI_Stype wt);
        #endregion

        #endregion

        #region ChildItems

        #region Generics

        public virtual DisplayedType AddFillDisplayedItem<T>(T T_Parent, Boolean fillData = true) where T : BaseType, IParent, new()
        {
            var childItemsList = AddChildItemsNode(T_Parent);
            var dNew = new DisplayedType(T_Parent);
            childItemsList.ListOfItems.Add(dNew);
            //dNew.RegisterParent(childItemsList);
            AddFillDisplayedTypeItems(dNew, fillData);
            return dNew;
        }
        public virtual SectionItemType AddFillSection<T>(T T_Parent, Boolean fillData = true) where T : BaseType, IParent, new()
        {
            var childItemsList = AddChildItemsNode(T_Parent);
            var sNew = AddFillNewSection(childItemsList, fillData);
            childItemsList.ListOfItems.Add(sNew);

            return sNew;
        }

        public virtual SectionItemType AddFillNewSection<T>(T T_Parent, Boolean fillData = true) where T : BaseType
        {
            var sNew = new SectionItemType(T_Parent);
            AddFillRepeatingTypeItems(sNew, fillData);

            if (fillData) FillSection(sNew);

            return sNew;
        }

        protected abstract SectionItemType FillSection(SectionItemType s);

        public abstract SectionBaseType FillSectionBase(SectionBaseType s);
        //public abstract QuestionItemType AddFillQuestion<T>(T T_Parent, QuestionEnum qType, Boolean fillData = true) where T : IParent, new();


        public virtual InjectFormType AddFillInjectedForm<T>(T T_Parent, Boolean fillData = true) where T : BaseType, IParent, new()
        {
            var childItems = AddChildItemsNode(T_Parent);
            var injForm = new InjectFormType(childItems);
            AddFillExtensionBaseTypeItems(injForm, fillData);
            childItems.ListOfItems.Add(injForm);

            injForm.RegisterParent(childItems);

            if (fillData) FillInjectedForm(injForm);

            return injForm;
        }

        protected abstract InjectFormType FillInjectedForm(InjectFormType injForm);


        public ButtonItemType AddFillButtonAction<T>(T T_Parent, Boolean fillData = true) where T : BaseType, IParent, new()
        {
            var childItems = AddChildItemsNode(T_Parent);
            var btnNew = new ButtonItemType(childItems);
            AddFillDisplayedTypeItems(btnNew, fillData);
            childItems.ListOfItems.Add(btnNew);

            //btnNew.RegisterParent(childItems);

            // TODO: Add TreeBuilder.AddButtonActionTypeItems(btnNew);
            return btnNew;
        }
        protected abstract ButtonItemType FillButton(ButtonItemType button);

        protected virtual ChildItemsType AddChildItemsNode<T>(T T_Parent) where T : BaseType, IParent, new()
        {
            ChildItemsType childItems = null;  //this class contains an "Items" list
            if (T_Parent == null)
                //childItems.RegisterParent(T_Parent);
                return childItems; //null
            else if (T_Parent.ChildItemsNode == null)
            {
                childItems = new ChildItemsType(T_Parent);
                T_Parent.ChildItemsNode = childItems;  //This may be null for the Header, Body and Footer  - need to check this
            }
            else //(T_Parent.ChildItemsNode != null)
                childItems = T_Parent.ChildItemsNode;
                //T_Parent.ChildItemsNode = childItems;
                //childItems.RegisterParent(T_Parent);

            if (childItems.ListOfItems == null)
                childItems.ListOfItems = new List<IdentifiedExtensionType>();

            return childItems;
        }
        #endregion

        #endregion

        #region Displayed Type
        public virtual PropertyType AddFillProperty(IdentifiedExtensionType dtParent, Boolean fillData = true)
        {
            var prop = new PropertyType(dtParent);
            AddFillExtensionBaseTypeItems(prop, false);

            if (dtParent.Property == null) dtParent.Property = new List<PropertyType>();
            dtParent.Property.Add(prop);
            //richText.RegisterParent(dtParent);

            //var html = AddHTML(richText);
            if (fillData) FillProperty(prop);
            return prop;
        }

        protected abstract PropertyType FillProperty(PropertyType ot, Boolean fillData = true);

        public virtual LinkType AddFillLink(DisplayedType dtParent, Boolean fillData = true)
        {
            var link = new LinkType(dtParent);
            AddFillExtensionBaseTypeItems(link, false);

            if (dtParent.Link == null) dtParent.Link = new List<LinkType>();
            dtParent.Link.Add(link);
            link.order = link.GetObjectID;

            //link.RegisterParent(dtParent);

            var rtf = new RichTextType(link);
            AddFillExtensionBaseTypeItems(rtf, false);
            link.LinkText = rtf;
            //rtf.RegisterParent(link);

            if (fillData) FillLinkText(link);


            return link;
        }

        protected abstract LinkType FillLinkText(LinkType lt);

        public virtual SDC.BlobType AddFillBlob(DisplayedType dtParent, Boolean fillData = true)
        {
            var blob = new BlobType(dtParent);
            AddFillExtensionBaseTypeItems(blob, false);
            if (dtParent.BlobContent == null) dtParent.BlobContent = new List<SDC.BlobType>();
            dtParent.BlobContent.Add(blob);
            //blob.RegisterParent(dtParent);

            if (fillData) FillBlob(blob);

            return blob;
        }
        protected abstract BlobType FillBlob(BlobType bt);

        public virtual IfThenType AddFillOnEvent(DisplayedType dtParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }
        protected abstract IfThenType FillOnEvent(IfThenType oe);

        public virtual IfThenType AddFillOnEnter(DisplayedType dtParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }
        protected abstract IfThenType FillOnEnter(IfThenType oe);

        public virtual OnEventType AddFillOnExit(DisplayedType dtParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }
        protected abstract OnEventType FillOnExit(OnEventType oe);

        public virtual WatchedPropertyType AddFillActivateIf(DisplayedType dtParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }
        protected abstract WatchedPropertyType FillActivateIf(WatchedPropertyType oe);

        public virtual WatchedPropertyType AddFillDeActivateIf(DisplayedType dtParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
        }
        protected abstract WatchedPropertyType FillDeActivateIf(WatchedPropertyType oeParent);

        #endregion

        #region Codes
        //!+CodedValues


        protected virtual UnitsType AddUnits(CodingType ctParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
            var u = new UnitsType(ctParent); //AddUnits<CodingType>(new CodingType());
            //TODO: See AddResponseUnits etc, and create new method for code units???
            ctParent.Units = u;
            //u.RegisterParent(ctParent);
            return u;
        }

        protected virtual CodeMatchType AddCodeMatch(CodingType ctParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
            var cm = new CodeMatchType(ctParent);
            ctParent.CodeMatch = cm;
            //cm.RegisterParent(ctParent);
            return cm;
        }
        protected virtual RichTextType AddCodeText(CodingType ctParent, Boolean fillData = true)
        {
            throw new NotImplementedException();
            var rt = new RichTextType(ctParent);
            ctParent.CodeText = rt;
            //rt.RegisterParent(ctParent);

            return rt;
        }

        protected virtual CodeSystemType AddFillCodeSystem(CodingType ctParent, Boolean fillData = true)
        {
            var cs = new CodeSystemType(ctParent);
            ctParent.CodeSystem = cs;
            //cs.RegisterParent(ctParent);
            if (fillData) FillCodeSystemItems(cs);
            return cs;
        }

        protected virtual CodeSystemType AddFillCodeSystem(ListFieldType lfParent, Boolean fillData = true)
        {
            var cs = new CodeSystemType(lfParent);
            lfParent.DefaultCodeSystem = cs;
            //cs.RegisterParent(lfParent);

            if (fillData) FillCodeSystemItems(cs);
            return cs;
        }
        protected abstract CodeSystemType FillCodeSystemItems(CodeSystemType cs);
        public abstract CodingType AddFillCodedValue(DisplayedType dtParent, Boolean fillData = true);
        protected abstract CodingType FillCodedValue(DisplayedType dt);

        /// <summary>
        /// Handles Response derived from a LookupEndpoint
        /// </summary>
        /// <param name="lepParent">LookupEndPointType</param>
        /// <param name="dr">DataRow</param>
        /// <returns></returns>
        public abstract CodingType AddFillCodedValue(LookupEndPointType lepParent, Boolean fillData = true);

        protected virtual List<CodingType> AddCodingList(DisplayedType dtParent, Boolean fillData = true)
        {
            List<CodingType> lct;

            if (dtParent.CodedValue == null)
            {
                lct = new List<CodingType>();
                dtParent.CodedValue = lct;
            }
            else lct = dtParent.CodedValue;
            return lct;
        }

        protected virtual List<CodingType> AddCodingList(LookupEndPointType epParent)
        {
            List<CodingType> lct;

            if (epParent.ResponseValue == null)
            {
                lct = new List<CodingType>();
                epParent.ResponseValue = lct;
            }
            else lct = epParent.ResponseValue;
            return lct;
        }


        #endregion

        #region IfThen
        protected virtual void AddFillActionToThenType(ThenType thenType, Boolean fillData = true)
        {

            throw new NotImplementedException();
            AddFillExtensionBaseTypeItems(thenType, false);
            //Add @onlyIf
            //Add PropertyAction
            //Add If LIstItemStatus
            //Add IfPredicate
            //Add IfGroup
        }


        #endregion

        #region QAS
        public virtual QuestionItemType AddFillQuestion<T>(T T_Parent, QuestionEnum qType, Boolean fillData = true) where T : BaseType, IParent, new()
        {
            var childItemsList = AddChildItemsNode(T_Parent);
            var qNew = new QuestionItemType(childItemsList);
            AddFillRepeatingTypeItems(qNew, fillData);
            childItemsList.ListOfItems.Add(qNew);
            if (fillData) qNew.FillQuestionItemBase();


            //qNew.RegisterParent(childItemsList);

            switch (qType)
            {
                case QuestionEnum.QuestionSingle:
                    AddListToListField(AddListFieldToQuestion(qNew));
                    if (fillData) FillListField(qNew.ListField_Item);
                    break;
                case QuestionEnum.QuestionMultiple:
                    AddListToListField(AddListFieldToQuestion(qNew));
                    qNew.ListField_Item.maxSelections = 0;
                    if (fillData) FillListField(qNew.ListField_Item);
                    break;
                case QuestionEnum.QuestionFill:
                    AddFillQuestionResponseField(qNew, fillData);
                    break;
                case QuestionEnum.QuestionLookup:
                    AddListFieldToQuestion(qNew);
                    if (fillData) FillListField(qNew.ListField_Item);
                    //AddEndpointToQuestion(qNew, qNew);
                    throw new NotImplementedException();
                //break;
                default:
                    break;
            }
            return qNew;
        }

        public abstract QuestionItemBaseType FillQuestionItemBase(QuestionItemBaseType q);

        #region List
        //!+List
        protected virtual ListFieldType AddListFieldToQuestion(QuestionItemType qParent)
        {
            if (qParent.ListField_Item == null)
            {
                var listField = new ListFieldType(qParent);
                qParent.ListField_Item = listField;
                //listField.RegisterParent(qParent);
            }

            return qParent.ListField_Item;
        }
        protected virtual ListType AddListToListField(ListFieldType listFieldParent)
        {
            ListType list;  //this is not the .NET List class; It's an answer list
            if (listFieldParent.List_Item == null)
            {
                list = new ListType(listFieldParent);
                listFieldParent.List_Item = list;
            }
            else list = listFieldParent.List_Item;
            //list.RegisterParent(listFieldParent);

            //The "list" item contains a list<DisplayedType>, to which the ListItems and ListNotes (DisplayedItems) are added.
            if (list.DisplayedItem_List == null)
                //listDT = new List<DisplayedType>();
                //list.DisplayedItem_List = listDT;
                list.DisplayedItem_List = new List<DisplayedType>();

            return list;
        }

        public abstract ListFieldType FillListField(ListFieldType lf);
        //protected abstract ListItemType FillListItemBaseType(ListItemType li, QuestionItemType qNode);
        public abstract ListItemBaseType FillListItemBase(ListItemBaseType li);


        public virtual DisplayedType AddFillListNoteToQuestion(QuestionItemType qParent, Boolean fillData = true)
        {
            return AddFillDisplayedItemToList(qParent, fillData);
        }

        public virtual ListItemType AddFillListItemToQuestion(QuestionItemType qParent, Boolean fillData = true)
        {
            return AddFillListItemToList(qParent, fillData);
        }

        protected virtual ListItemType AddFillListItemToList(QuestionItemType qParent, Boolean fillData = true)
        {
            var list = qParent.ListField_Item.List_Item;
            var li = new ListItemType();
            list.DisplayedItem_List.Add(li);
            //li.RegisterParent(list);

            if (fillData) FillListItemBase(li);

            return li;
        }
        public virtual DisplayedType AddFillDisplayedItemToList(QuestionItemType qParent, Boolean fillData = true)
        {
            var list = qParent.ListField_Item.List_Item;
            var di = new DisplayedType(list);
            //list.DisplayedItem_List.Add(di); //This line forces all the DisplayedItems to of the list.
            list.Items.Add(di);  //This line should allow DisplayedItems interspersed with ListITems.
            //di.RegisterParent(list);

            AddFillDisplayedTypeItems(di, fillData);
            //FillDisplayedTypeItems(di);
            if (fillData) FillDisplayedTypeListItem(di, di.title, qParent);

            return di;
        }
        #endregion


        #region Response
        //!+Create Response Items
        protected virtual ResponseFieldType AddFillQuestionResponseField(QuestionItemType qParent, Boolean fillData = true)
        {
            //Add Response, TextAfterResponse (RichTextType), ReponseUnits, SetValueExpression
            var rf = new ResponseFieldType(qParent);
            AddFillResponseFieldItems(rf, fillData);
            qParent.ResponseField_Item = rf;
            //rf.RegisterParent(qParent);

            if (fillData) FillResponseField(rf);

            return rf;
        }

        public virtual ListItemResponseFieldType AddFillListItemResponseField(ListItemBaseType liParent, Boolean fillData = true)
        {
            var liRF = new ListItemResponseFieldType(liParent);
            AddFillResponseFieldItems(liRF, fillData);
            liParent.ListItemResponseField = liRF;
            //liRF.RegisterParent(liParent);

            if (fillData) FillListItemResponseField(liRF);

            return liRF;
        }
        protected virtual ResponseFieldType AddFillResponseFieldItems(ResponseFieldType rfParent, Boolean fillData = true)
        {
            AddFillExtensionBaseTypeItems(rfParent, fillData);
            AddFillResponseUnits(rfParent, fillData);
            if (fillData) AddFillDataTypesDE(rfParent);
            return rfParent;
        }
        protected abstract ResponseFieldType FillResponseField(ResponseFieldType rf);
        protected abstract UnitsType AddFillResponseUnits(ResponseFieldType rfParent, Boolean fillData = true);
        public abstract UnitsType FillUnits(UnitsType ut);

        public abstract ListItemResponseFieldType FillListItemResponseField(ListItemResponseFieldType lirf);  //, ListItemBaseType li);
        //protected abstract BaseType AddDataTypeToResponseType(ResponseFieldType rf);
        //public abstract ResponseFieldType AddResponseItems(ResponseFieldType rf);
        //public abstract void FillResponseItems();
        //protected abstract ResponseFieldType FillResponseItems(ResponseFieldType rf);  //already have this function above


        //protected virtual ResponseChangeType AddFillResponseHistoryToQuestion(QuestionItemType q, Boolean fillData = true)
        //{
        //    if (q.ResponseHistory == null) q.ResponseHistory = new List<ResponseChangeType>();
        //    var respChange = new ResponseChangeType(q);
        //    q.ResponseHistory.Add(respChange);
        //    respChange.RegisterParent(q);

        //    if (fillData) FillResponseChange(respChange);
        //    AddFillReplacedResponse(respChange, fillData);

        //    return respChange;
        //}
        //protected abstract ResponseChangeType FillResponseChange(ResponseChangeType respChange);


        //protected virtual ReplacedResponseType AddFillReplacedResponse(ResponseChangeType respChange, Boolean fillData = true)
        //{
        //    var replResp = new ReplacedResponseType(respChange);
        //    respChange.ReplacedResponse = replResp;
        //    //replResp.RegisterParent(respChange);

        //    if (fillData) FillReplacedResponse(replResp);
        //    //MessageBox.Show("AddReplacedResponseToResponseHistory not implemented yet");
        //    return replResp;
        //}
        //protected abstract ReplacedResponseType FillReplacedResponse(ReplacedResponseType replResp);



        #endregion

        #region LookupEndpoint
        //!Add LookupEndpoint to Question w ListField
        protected virtual LookupEndPointType AddEndpointToQuestion(ListFieldType listFieldParent, Boolean fillData = true)
        {
            //Add ResponseComment, Editor, DateTime, Response, SelectedItems
            //TODO: must determine if the current ListField should take a lookupEndpoint
            var lep = new LookupEndPointType(listFieldParent);
            listFieldParent.LookupEndpoint_Item = lep;
            lep.RegisterParent(listFieldParent);

            if (fillData) FillLookupEndpoint(lep);
            return lep;
        }

        public abstract LookupEndPointType FillLookupEndpoint(LookupEndPointType lep);
        #endregion

        #endregion

        #region Rules
        //!+Rules
        protected virtual RulesType AddRuleToDisplayedType(DisplayedType parent)
        {
            //FormAction
            //PropertyAction,
            //If ListItemStatus,
            //If Predicate,
            //IfGroup
            return new RulesType(parent);
        }
        #endregion

        #region Utilities
        ///// <summary>
        ///// Converts the string expression of an enum value to the desired type. Example: var qType= reeBuilder.ConvertStringToEnum&lt;ItemType&gt;("answer");
        ///// </summary>
        ///// <typeparam name="Tenum">The enum type that the inputString will be converted into.</typeparam>
        ///// <param name="inputString">The string that must represent one of the Tenum enumerated values; not case sensitive</param>
        ///// <returns></returns>
        //public static Tenum ConvertStringToEnum<Tenum>(string inputString) where Tenum : struct
        //{
        //    //T newEnum = (T)Enum.Parse(typeof(T), inputString, true);

        //    Tenum newEnum;
        //    if (Enum.TryParse<Tenum>(inputString, true, out newEnum))
        //    {
        //        return newEnum;
        //    }
        //    else
        //    { //throw new Exception("Failure to create enum");

        //    }
        //    return newEnum;
        //}

        #endregion

        #region Actions

        public abstract ActSendMessageType AddFillActSendMessage(ThenType tt, Boolean fillData = true);
        public abstract ActActionType AddAction(ThenType tt, Boolean fillData = true);
        //public abstract ActSetPropertyType AddSetProperty(ThenType tt, Boolean fillData = true);
        public abstract ActAddCodeType AddAddCode(ThenType tt, Boolean fillData = true);
        //public abstract ActSetValueType AddSetValue(ThenType tt, Boolean fillData = true);
        public abstract ActInjectType AddInject(ThenType tt, Boolean fillData = true);
        public abstract ActShowMessageType AddShowMessage(ThenType tt, Boolean fillData = true);
        //public abstract ExpressionType AddRunCommand(ThenType tt, Boolean fillData = true);
        public abstract FuncType AddShowURL(ThenType tt, Boolean fillData = true);
        public abstract ActShowFormType AddShowForm(ThenType tt, Boolean fillData = true);
        public abstract ActSaveResponsesType AddSave(ThenType tt, Boolean fillData = true);
        public abstract ActSendReportType AddShowReport(ThenType tt, Boolean fillData = true);
        public abstract ActSendMessageType AddSendMessage(ThenType tt, Boolean fillData = true);
        public abstract ActValidateFormType AddValidateForm(ThenType tt, Boolean fillData = true);
        public abstract IfThenType AddIfThen(ThenType tt, Boolean fillData = true);
        public abstract ItemNameType AddCallIfThen(ThenType tt, Boolean fillData = true);

        #endregion

        #region Rules

        //RuleAutoSelectType
        //RuleSelectionTestType
        //RuleIllegalSelectionSetsType
        //SelectionSetBoolType
        //RulesCollectionType
        //RuleReferenceType
        #endregion


        #region Resources

        //protected RichTextType xAddRichText<T>(T t, string strHTML = "", string val = "") where T : BaseType
        //{
        //    throw new NotImplementedException();

        //    var rtf = new RichTextType(t);
        //    //var html = AddFillHTML(rtf);

        //    return rtf;
        //}

        //protected RichTextType xFillRichText(RichTextType rtParent, string val = "", Boolean fillData = true, string strHTML = "")
        //{
        //    throw new NotImplementedException();
        //    rtParent.val = val;

        //    //var html = AddFillHTML(rtParent, fillData, strHTML);

        //    return rtParent;
        //}

        public abstract HTML_Stype AddFillHTML(RichTextType rt, Boolean fillData = true, string InXhtml = "");


        #endregion

    }

}


