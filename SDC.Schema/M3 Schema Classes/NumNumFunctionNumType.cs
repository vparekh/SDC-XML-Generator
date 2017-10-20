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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Num.NumFunction.NumType", Namespace="urn:ihe:qrph:sdc:2016")]
public partial class NumNumFunctionNumType : ReturnNumType
{
    
    #region Private fields
    private bool _shouldSerializeparam;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ExtensionBaseType _item2;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private Item2ChoiceType _item2ElementName;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<NumNumFunctionNumTypeOpMathList> _opMathList;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<double> _param;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("Group", typeof(NumNumFunctionNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ListAggregateNumber", typeof(ListAggregateNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ListMath", typeof(ListAggregateNumType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Number", typeof(DataTypesNumeric_DEType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("NumberReference", typeof(RefNumType), Order=0)]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
    public virtual ExtensionBaseType Item2
    {
        get
        {
            return this._item2;
        }
        set
        {
            this._item2 = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual Item2ChoiceType Item2ElementName
    {
        get
        {
            return this._item2ElementName;
        }
        set
        {
            this._item2ElementName = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual NumNumFunctionNumTypeOpMathList opMathList
    {
        get
        {
            if (this._opMathList.HasValue)
            {
                return this._opMathList.Value;
            }
            else
            {
                return default(NumNumFunctionNumTypeOpMathList);
            }
        }
        set
        {
            this._opMathList = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool opMathListSpecified
    {
        get
        {
            return this._opMathList.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._opMathList = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual double param
    {
        get
        {
            if (this._param.HasValue)
            {
                return this._param.Value;
            }
            else
            {
                return default(double);
            }
        }
        set
        {
            this._param = value;
            _shouldSerializeparam = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool paramSpecified
    {
        get
        {
            return this._param.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._param = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NumNumFunctionNumType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether param should be serialized
    /// </summary>
    public virtual bool ShouldSerializeparam()
    {
        if (_shouldSerializeparam)
        {
            return true;
        }
        return (_param != default(double));
    }
    
    /// <summary>
    /// Test whether Item2 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem2()
    {
        return (_item2 != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current NumNumFunctionNumType object into an XML string
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
    /// Deserializes workflow markup into an NumNumFunctionNumType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NumNumFunctionNumType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NumNumFunctionNumType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NumNumFunctionNumType);
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
    
    public static bool Deserialize(string input, out NumNumFunctionNumType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NumNumFunctionNumType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NumNumFunctionNumType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NumNumFunctionNumType Deserialize(System.IO.Stream s)
    {
        return ((NumNumFunctionNumType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NumNumFunctionNumType object into file
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
    /// Deserializes xml markup from file into an NumNumFunctionNumType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NumNumFunctionNumType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out NumNumFunctionNumType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NumNumFunctionNumType);
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
    
    public static bool LoadFromFile(string fileName, out NumNumFunctionNumType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out NumNumFunctionNumType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static NumNumFunctionNumType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NumNumFunctionNumType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
