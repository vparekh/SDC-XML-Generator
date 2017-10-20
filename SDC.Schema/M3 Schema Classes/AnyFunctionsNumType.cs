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

[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsNumListOrNumType111))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Any.Functions.NumType", Namespace="urn:ihe:qrph:sdc:2016")]
public partial class AnyFunctionsNumType : ReturnNumType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<object> _items;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("Constant", typeof(NumericConstantsType111), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ConvertToNum", typeof(AnyConvertNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("DateTimeComparison", typeof(DateTimeCompareIntegerType111), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("FuncInt", typeof(FuncIntegerType000), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("FuncNum", typeof(FuncNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("GetAttrValue", typeof(GetNumAttrValueType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("GetListItem.Num", typeof(ListGetItemAtIndexNumType000), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Group", typeof(AnyFunctionsNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("IntegerFunction111", typeof(IntegerFunctionInteger111), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ListMath", typeof(ListAggregateNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("MathFunction", typeof(NumNumFunctionNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Ref", typeof(RefNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Script", typeof(ScriptCodeNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Trig111", typeof(NumTrigNumType111), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("___StrToNumOrNumList", typeof(object), Order=0)]
    public virtual List<object> Items
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
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(AnyFunctionsNumType));
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
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AnyFunctionsNumType object into an XML string
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
    /// Deserializes workflow markup into an AnyFunctionsNumType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output AnyFunctionsNumType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out AnyFunctionsNumType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(AnyFunctionsNumType);
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
    
    public static bool Deserialize(string input, out AnyFunctionsNumType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static AnyFunctionsNumType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((AnyFunctionsNumType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static AnyFunctionsNumType Deserialize(System.IO.Stream s)
    {
        return ((AnyFunctionsNumType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current AnyFunctionsNumType object into file
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
    /// Deserializes xml markup from file into an AnyFunctionsNumType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AnyFunctionsNumType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out AnyFunctionsNumType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(AnyFunctionsNumType);
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
    
    public static bool LoadFromFile(string fileName, out AnyFunctionsNumType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out AnyFunctionsNumType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static AnyFunctionsNumType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static AnyFunctionsNumType LoadFromFile(string fileName, System.Text.Encoding encoding)
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