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
/// Sets the value of any named attribute.  However, it is primarily designed for Response element(s) on a Question or ListItem.  The value may be determined by a literal value with a defined data type, the value at another named Response item, an expression written in a specified scripting or programming language, or the value of a named code listed in the same template.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class ActSetValueBoolType : PredicateType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _attributeName;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _elementName;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _x_targetNames;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// ActSetValueBoolType class constructor
    /// </summary>
    public ActSetValueBoolType()
    {
        this._attributeName = "val";
    }
    
    /// <summary>
    /// The name of any attribute on a named element.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    [System.ComponentModel.DefaultValueAttribute("val")]
    public virtual string attributeName
    {
        get
        {
            return this._attributeName;
        }
        set
        {
            this._attributeName = value;
        }
    }
    
    /// <summary>
    /// The @name attribute of the referenced element.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public virtual string elementName
    {
        get
        {
            return this._elementName;
        }
        set
        {
            this._elementName = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string X_targetNames
    {
        get
        {
            return this._x_targetNames;
        }
        set
        {
            this._x_targetNames = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ActSetValueBoolType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether attributeName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeattributeName()
    {
        return !string.IsNullOrEmpty(attributeName);
    }
    
    /// <summary>
    /// Test whether elementName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeelementName()
    {
        return !string.IsNullOrEmpty(elementName);
    }
    
    /// <summary>
    /// Test whether X_targetNames should be serialized
    /// </summary>
    public virtual bool ShouldSerializeX_targetNames()
    {
        return !string.IsNullOrEmpty(X_targetNames);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ActSetValueBoolType object into an XML string
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
    /// Deserializes workflow markup into an ActSetValueBoolType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ActSetValueBoolType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ActSetValueBoolType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ActSetValueBoolType);
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
    
    public static bool Deserialize(string input, out ActSetValueBoolType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ActSetValueBoolType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((ActSetValueBoolType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ActSetValueBoolType Deserialize(System.IO.Stream s)
    {
        return ((ActSetValueBoolType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ActSetValueBoolType object into file
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
    /// Deserializes xml markup from file into an ActSetValueBoolType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ActSetValueBoolType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ActSetValueBoolType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ActSetValueBoolType);
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
    
    public static bool LoadFromFile(string fileName, out ActSetValueBoolType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out ActSetValueBoolType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static ActSetValueBoolType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static ActSetValueBoolType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
