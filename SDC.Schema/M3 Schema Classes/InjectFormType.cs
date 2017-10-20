// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

/// <summary>
/// CHANGED:
/// This type represents a form or portion of a form that is imported into the current form at a specific location.  It allows the composition of forms from other forms or parts of other forms.
/// 
/// In practice, using an injected section will requiresome or all of the injected FormDesignXML to be injected under this the InjectForm element.  For that reason, the schema supports those elements to appear inline.  However, in a "raw" form (not yet filled out), the FormDesign element would generally be empty; only the top-level InjectFormType attributes would be used to point to the parts to be later injected.
/// 
/// Form parts to be injected are specified by packageID, not FormID.  This allows an injected form to be assocaited with helper files, or to return previosuly completed form parts containing responses.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActInjectType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class InjectFormType : IdentifiedExtensionType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private IdentifiedExtensionType _item;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _packageID;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _rootItemID;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _injectionID;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("FormDesign", typeof(FormDesignType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Question", typeof(QuestionItemType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Section", typeof(SectionItemType), Order=0)]
    public virtual IdentifiedExtensionType Item
    {
        get
        {
            return this._item;
        }
        set
        {
            this._item = value;
        }
    }
    
    /// <summary>
    /// This ID represents the Package that contains the form to be injected.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string packageID
    {
        get
        {
            return this._packageID;
        }
        set
        {
            this._packageID = value;
        }
    }
    
    /// <summary>
    /// The rootItemID is the ID of the form part that will be injected.  If empty, then the entre form shoudl be injected under the FormDesign element node.  If not empty, it must point to a valid Section or Question.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string rootItemID
    {
        get
        {
            return this._rootItemID;
        }
        set
        {
            this._rootItemID = value;
        }
    }
    
    /// <summary>
    /// Unique ID (GUID) to distinguish multiple instances of the same injected node.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string injectionID
    {
        get
        {
            return this._injectionID;
        }
        set
        {
            this._injectionID = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(InjectFormType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether packageID should be serialized
    /// </summary>
    public virtual bool ShouldSerializepackageID()
    {
        return !string.IsNullOrEmpty(packageID);
    }
    
    /// <summary>
    /// Test whether rootItemID should be serialized
    /// </summary>
    public virtual bool ShouldSerializerootItemID()
    {
        return !string.IsNullOrEmpty(rootItemID);
    }
    
    /// <summary>
    /// Test whether injectionID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeinjectionID()
    {
        return !string.IsNullOrEmpty(injectionID);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current InjectFormType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize(System.Text.Encoding encoding)
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Encoding = encoding;
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = " ";
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream, encoding);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    public virtual string Serialize()
    {
        return Serialize(System.Text.Encoding.UTF8);
    }
    
    /// <summary>
    /// Deserializes workflow markup into an InjectFormType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output InjectFormType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out InjectFormType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(InjectFormType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out InjectFormType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static InjectFormType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((InjectFormType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static InjectFormType Deserialize(System.IO.Stream s)
    {
        return ((InjectFormType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current InjectFormType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName, encoding);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        return SaveToFile(fileName, System.Text.Encoding.UTF8, out exception);
    }
    
    public virtual void SaveToFile(string fileName)
    {
        SaveToFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize(encoding);
            streamWriter = new System.IO.StreamWriter(fileName, false, encoding);
            streamWriter.WriteLine(xmlString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an InjectFormType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output InjectFormType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out InjectFormType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(InjectFormType);
        try
        {
            obj = LoadFromFile(fileName, encoding);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out InjectFormType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out InjectFormType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static InjectFormType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static InjectFormType LoadFromFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file, encoding);
            string xmlString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(xmlString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
}
}
#pragma warning restore
