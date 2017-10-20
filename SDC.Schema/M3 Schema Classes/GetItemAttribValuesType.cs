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
/// In the PropertyValues condition, the contained Boolean attributed values are ANDed together (by default) to return a derived Boolean value.  Omitted (null) values are ignored and not used for null propagation.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class GetItemAttribValuesType : ReturnBoolType
{
    
    #region Private fields
    private bool _shouldSerializeisReadOnly;
    
    private bool _shouldSerializeisRequired;
    
    private bool _shouldSerializeisEnabled;
    
    private bool _shouldSerializeisVisible;
    
    private bool _shouldSerializehasResponse;
    
    private bool _shouldSerializeisActive;
    
    private bool _shouldSerializeisSelected;
    
    private bool _shouldSerializenot;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _not;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BoolListTypeBoolOp _boolOp;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _itemNames;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _isSelected;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _isActive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _hasSelectionsGTE;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _hasSelectionsLTE;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _hasSelectionsExact;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _hasResponse;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _isVisible;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _isEnabled;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _isRequired;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _isReadOnly;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _hasType;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _hasStyleClass;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// GetItemAttribValuesType class constructor
    /// </summary>
    public GetItemAttribValuesType()
    {
        this._not = false;
        this._boolOp = BoolListTypeBoolOp.AND;
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool not
    {
        get
        {
            if (this._not.HasValue)
            {
                return this._not.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._not = value;
            _shouldSerializenot = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool notSpecified
    {
        get
        {
            return this._not.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._not = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(BoolListTypeBoolOp.AND)]
    public virtual BoolListTypeBoolOp boolOp
    {
        get
        {
            return this._boolOp;
        }
        set
        {
            this._boolOp = value;
        }
    }
    
    /// <summary>
    /// Required name(s) of the item(s) (Section, Question, List Item) that contains the item properties used in the other attributes.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string itemNames
    {
        get
        {
            return this._itemNames;
        }
        set
        {
            this._itemNames = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isSelected
    {
        get
        {
            if (this._isSelected.HasValue)
            {
                return this._isSelected.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._isSelected = value;
            _shouldSerializeisSelected = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool isSelectedSpecified
    {
        get
        {
            return this._isSelected.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._isSelected = null;
            }
        }
    }
    
    /// <summary>
    /// If visible and enabled are both true, then isActive is true.  Otherwise, it is false.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isActive
    {
        get
        {
            if (this._isActive.HasValue)
            {
                return this._isActive.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._isActive = value;
            _shouldSerializeisActive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool isActiveSpecified
    {
        get
        {
            return this._isActive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._isActive = null;
            }
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists (ListItems or LookupField).  Evaluates to true if the number of selected items equals or exceeds the entered value.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public virtual string hasSelectionsGTE
    {
        get
        {
            return this._hasSelectionsGTE;
        }
        set
        {
            this._hasSelectionsGTE = value;
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists (ListItems or LookupField).  Evaluates to true if the number of selected items is less than or equal to the entered value.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public virtual string hasSelectionsLTE
    {
        get
        {
            return this._hasSelectionsLTE;
        }
        set
        {
            this._hasSelectionsLTE = value;
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists (ListItems or LookupField).  Evaluates to true if the number of selected items equals the entered value.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public virtual string hasSelectionsExact
    {
        get
        {
            return this._hasSelectionsExact;
        }
        set
        {
            this._hasSelectionsExact = value;
        }
    }
    
    /// <summary>
    /// Applies only to items that have Response Fields (Questions and ListItems).  If the ListItem or Question has a Response Field, and that field has a value in it, this property returns true.  If it does not have a value, it returns false.  If no Response Field is present, it retuns null and is not used for Boolean comparisons.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool hasResponse
    {
        get
        {
            if (this._hasResponse.HasValue)
            {
                return this._hasResponse.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._hasResponse = value;
            _shouldSerializehasResponse = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool hasResponseSpecified
    {
        get
        {
            return this._hasResponse.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._hasResponse = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isVisible
    {
        get
        {
            if (this._isVisible.HasValue)
            {
                return this._isVisible.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._isVisible = value;
            _shouldSerializeisVisible = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool isVisibleSpecified
    {
        get
        {
            return this._isVisible.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._isVisible = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isEnabled
    {
        get
        {
            if (this._isEnabled.HasValue)
            {
                return this._isEnabled.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._isEnabled = value;
            _shouldSerializeisEnabled = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool isEnabledSpecified
    {
        get
        {
            return this._isEnabled.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._isEnabled = null;
            }
        }
    }
    
    /// <summary>
    /// If the minCard value is greater than 0, then isRequired = "true"
    /// If the minCard = "0" then isRequired = "false"
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isRequired
    {
        get
        {
            if (this._isRequired.HasValue)
            {
                return this._isRequired.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._isRequired = value;
            _shouldSerializeisRequired = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool isRequiredSpecified
    {
        get
        {
            return this._isRequired.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._isRequired = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isReadOnly
    {
        get
        {
            if (this._isReadOnly.HasValue)
            {
                return this._isReadOnly.Value;
            }
            else
            {
                return default(bool);
            }
        }
        set
        {
            this._isReadOnly = value;
            _shouldSerializeisReadOnly = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool isReadOnlySpecified
    {
        get
        {
            return this._isReadOnly.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._isReadOnly = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string hasType
    {
        get
        {
            return this._hasType;
        }
        set
        {
            this._hasType = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string hasStyleClass
    {
        get
        {
            return this._hasStyleClass;
        }
        set
        {
            this._hasStyleClass = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(GetItemAttribValuesType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether not should be serialized
    /// </summary>
    public virtual bool ShouldSerializenot()
    {
        if (_shouldSerializenot)
        {
            return true;
        }
        return (_not != default(bool));
    }
    
    /// <summary>
    /// Test whether isSelected should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisSelected()
    {
        if (_shouldSerializeisSelected)
        {
            return true;
        }
        return (_isSelected != default(bool));
    }
    
    /// <summary>
    /// Test whether isActive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisActive()
    {
        if (_shouldSerializeisActive)
        {
            return true;
        }
        return (_isActive != default(bool));
    }
    
    /// <summary>
    /// Test whether hasResponse should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasResponse()
    {
        if (_shouldSerializehasResponse)
        {
            return true;
        }
        return (_hasResponse != default(bool));
    }
    
    /// <summary>
    /// Test whether isVisible should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisVisible()
    {
        if (_shouldSerializeisVisible)
        {
            return true;
        }
        return (_isVisible != default(bool));
    }
    
    /// <summary>
    /// Test whether isEnabled should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisEnabled()
    {
        if (_shouldSerializeisEnabled)
        {
            return true;
        }
        return (_isEnabled != default(bool));
    }
    
    /// <summary>
    /// Test whether isRequired should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisRequired()
    {
        if (_shouldSerializeisRequired)
        {
            return true;
        }
        return (_isRequired != default(bool));
    }
    
    /// <summary>
    /// Test whether isReadOnly should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisReadOnly()
    {
        if (_shouldSerializeisReadOnly)
        {
            return true;
        }
        return (_isReadOnly != default(bool));
    }
    
    /// <summary>
    /// Test whether itemNames should be serialized
    /// </summary>
    public virtual bool ShouldSerializeitemNames()
    {
        return !string.IsNullOrEmpty(itemNames);
    }
    
    /// <summary>
    /// Test whether hasSelectionsGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsGTE()
    {
        return !string.IsNullOrEmpty(hasSelectionsGTE);
    }
    
    /// <summary>
    /// Test whether hasSelectionsLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsLTE()
    {
        return !string.IsNullOrEmpty(hasSelectionsLTE);
    }
    
    /// <summary>
    /// Test whether hasSelectionsExact should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsExact()
    {
        return !string.IsNullOrEmpty(hasSelectionsExact);
    }
    
    /// <summary>
    /// Test whether hasType should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasType()
    {
        return !string.IsNullOrEmpty(hasType);
    }
    
    /// <summary>
    /// Test whether hasStyleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasStyleClass()
    {
        return !string.IsNullOrEmpty(hasStyleClass);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current GetItemAttribValuesType object into an XML string
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
    /// Deserializes workflow markup into an GetItemAttribValuesType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output GetItemAttribValuesType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out GetItemAttribValuesType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(GetItemAttribValuesType);
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
    
    public static bool Deserialize(string input, out GetItemAttribValuesType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static GetItemAttribValuesType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((GetItemAttribValuesType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static GetItemAttribValuesType Deserialize(System.IO.Stream s)
    {
        return ((GetItemAttribValuesType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current GetItemAttribValuesType object into file
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
    /// Deserializes xml markup from file into an GetItemAttribValuesType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output GetItemAttribValuesType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out GetItemAttribValuesType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(GetItemAttribValuesType);
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
    
    public static bool LoadFromFile(string fileName, out GetItemAttribValuesType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out GetItemAttribValuesType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static GetItemAttribValuesType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static GetItemAttribValuesType LoadFromFile(string fileName, System.Text.Encoding encoding)
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