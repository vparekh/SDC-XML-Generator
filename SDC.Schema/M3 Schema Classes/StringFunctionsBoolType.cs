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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="String.Functions.BoolType", Namespace="urn:ihe:qrph:sdc:2016")]
public partial class StringFunctionsBoolType : ReturnBoolType
{
    
    #region Private fields
    private bool _shouldSerializenot;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<ReturnBoolType> _items;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<bool> _not;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BoolListTypeBoolOp _boolOp;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// StringFunctionsBoolType class constructor
    /// </summary>
    public StringFunctionsBoolType()
    {
        this._not = false;
        this._boolOp = BoolListTypeBoolOp.AND;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(StringContainsBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("EndsWith", typeof(StringEndsWithBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("FunctionBool", typeof(FuncBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("IsEmpty", typeof(StringIsEmptyBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("IsNull", typeof(StringIsNullBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("IsNullOrEmpty", typeof(StringIsNullOrEmptyBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Like", typeof(StringLikeBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("StartsWith", typeof(StringStartsWithBoolType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("StringPredicate", typeof(StringFunctionsBoolType), Order=0)]
    public virtual List<ReturnBoolType> Items
    {
        get
        {
            return this._items;
        }
        set
        {
            this._items = value;
        }
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
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(StringFunctionsBoolType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether Items should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItems()
    {
        return Items != null && Items.Count > 0;
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
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current StringFunctionsBoolType object into an XML string
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
    /// Deserializes workflow markup into an StringFunctionsBoolType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output StringFunctionsBoolType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out StringFunctionsBoolType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(StringFunctionsBoolType);
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
    
    public static bool Deserialize(string input, out StringFunctionsBoolType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static StringFunctionsBoolType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((StringFunctionsBoolType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static StringFunctionsBoolType Deserialize(System.IO.Stream s)
    {
        return ((StringFunctionsBoolType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current StringFunctionsBoolType object into file
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
    /// Deserializes xml markup from file into an StringFunctionsBoolType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output StringFunctionsBoolType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out StringFunctionsBoolType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(StringFunctionsBoolType);
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
    
    public static bool LoadFromFile(string fileName, out StringFunctionsBoolType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out StringFunctionsBoolType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static StringFunctionsBoolType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static StringFunctionsBoolType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
