// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
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
/// A alert is a message displayed to the form user, triggered by activity within the form.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
public partial class ActShowMessageType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<RichTextType> _message;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _alertLevel;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _alertType;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _messageType;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _messageCode;
    
    private static XmlSerializer serializer;
    
    [System.Xml.Serialization.XmlElementAttribute("Message", Order=0)]
    public virtual List<RichTextType> Message
    {
        get
        {
            return this._message;
        }
        set
        {
            this._message = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string alertLevel
    {
        get
        {
            return this._alertLevel;
        }
        set
        {
            this._alertLevel = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string alertType
    {
        get
        {
            return this._alertType;
        }
        set
        {
            this._alertType = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string messageType
    {
        get
        {
            return this._messageType;
        }
        set
        {
            this._messageType = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string messageCode
    {
        get
        {
            return this._messageCode;
        }
        set
        {
            this._messageCode = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ActShowMessageType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether Message should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMessage()
    {
        return Message != null && Message.Count > 0;
    }
    
    /// <summary>
    /// Test whether alertLevel should be serialized
    /// </summary>
    public virtual bool ShouldSerializealertLevel()
    {
        return !string.IsNullOrEmpty(alertLevel);
    }
    
    /// <summary>
    /// Test whether alertType should be serialized
    /// </summary>
    public virtual bool ShouldSerializealertType()
    {
        return !string.IsNullOrEmpty(alertType);
    }
    
    /// <summary>
    /// Test whether messageType should be serialized
    /// </summary>
    public virtual bool ShouldSerializemessageType()
    {
        return !string.IsNullOrEmpty(messageType);
    }
    
    /// <summary>
    /// Test whether messageCode should be serialized
    /// </summary>
    public virtual bool ShouldSerializemessageCode()
    {
        return !string.IsNullOrEmpty(messageCode);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ActShowMessageType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream);
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
    
    /// <summary>
    /// Deserializes workflow markup into an ActShowMessageType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ActShowMessageType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ActShowMessageType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ActShowMessageType);
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
    
    public static bool Deserialize(string input, out ActShowMessageType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ActShowMessageType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((ActShowMessageType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ActShowMessageType Deserialize(System.IO.Stream s)
    {
        return ((ActShowMessageType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ActShowMessageType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
            streamWriter = xmlFile.CreateText();
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
    /// Deserializes xml markup from file into an ActShowMessageType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ActShowMessageType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ActShowMessageType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ActShowMessageType);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out ActShowMessageType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static ActShowMessageType LoadFromFile(string fileName)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file);
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