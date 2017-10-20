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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="StrList.IndexOf.IntegerType", Namespace="urn:ihe:qrph:sdc:2016")]
public partial class StrListIndexOfIntegerType : InputStr_ReturnIntegerType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _matchExpression;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _matchPattern;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _index;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<StrListIndexOfIntegerTypeMatchType> _matchType;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string matchExpression
    {
        get
        {
            return this._matchExpression;
        }
        set
        {
            this._matchExpression = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string matchPattern
    {
        get
        {
            return this._matchPattern;
        }
        set
        {
            this._matchPattern = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public virtual string index
    {
        get
        {
            return this._index;
        }
        set
        {
            this._index = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual StrListIndexOfIntegerTypeMatchType matchType
    {
        get
        {
            if (this._matchType.HasValue)
            {
                return this._matchType.Value;
            }
            else
            {
                return default(StrListIndexOfIntegerTypeMatchType);
            }
        }
        set
        {
            this._matchType = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool matchTypeSpecified
    {
        get
        {
            return this._matchType.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._matchType = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(StrListIndexOfIntegerType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether matchExpression should be serialized
    /// </summary>
    public virtual bool ShouldSerializematchExpression()
    {
        return !string.IsNullOrEmpty(matchExpression);
    }
    
    /// <summary>
    /// Test whether matchPattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializematchPattern()
    {
        return !string.IsNullOrEmpty(matchPattern);
    }
    
    /// <summary>
    /// Test whether index should be serialized
    /// </summary>
    public virtual bool ShouldSerializeindex()
    {
        return !string.IsNullOrEmpty(index);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current StrListIndexOfIntegerType object into an XML string
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
    /// Deserializes workflow markup into an StrListIndexOfIntegerType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output StrListIndexOfIntegerType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out StrListIndexOfIntegerType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(StrListIndexOfIntegerType);
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
    
    public static bool Deserialize(string input, out StrListIndexOfIntegerType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static StrListIndexOfIntegerType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((StrListIndexOfIntegerType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static StrListIndexOfIntegerType Deserialize(System.IO.Stream s)
    {
        return ((StrListIndexOfIntegerType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current StrListIndexOfIntegerType object into file
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
    /// Deserializes xml markup from file into an StrListIndexOfIntegerType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output StrListIndexOfIntegerType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out StrListIndexOfIntegerType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(StrListIndexOfIntegerType);
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
    
    public static bool LoadFromFile(string fileName, out StrListIndexOfIntegerType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out StrListIndexOfIntegerType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static StrListIndexOfIntegerType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static StrListIndexOfIntegerType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
