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
/// ***Changed from BaseType to ExtensionBaseType
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class DestinationType : ExtensionBaseType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private anyURI_Stype _endpoint;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string_Stype _endpointDescription;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<string_Stype> _submissionTechnology;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private OrganizationType _organization;
    
    private static XmlSerializer serializer;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual anyURI_Stype Endpoint
    {
        get
        {
            return this._endpoint;
        }
        set
        {
            this._endpoint = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual string_Stype EndpointDescription
    {
        get
        {
            return this._endpointDescription;
        }
        set
        {
            this._endpointDescription = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("SubmissionTechnology", Order=2)]
    public virtual List<string_Stype> SubmissionTechnology
    {
        get
        {
            return this._submissionTechnology;
        }
        set
        {
            this._submissionTechnology = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public virtual OrganizationType Organization
    {
        get
        {
            return this._organization;
        }
        set
        {
            this._organization = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(DestinationType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether SubmissionTechnology should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSubmissionTechnology()
    {
        return SubmissionTechnology != null && SubmissionTechnology.Count > 0;
    }
    
    /// <summary>
    /// Test whether Endpoint should be serialized
    /// </summary>
    public virtual bool ShouldSerializeEndpoint()
    {
        return (_endpoint != null);
    }
    
    /// <summary>
    /// Test whether EndpointDescription should be serialized
    /// </summary>
    public virtual bool ShouldSerializeEndpointDescription()
    {
        return (_endpointDescription != null);
    }
    
    /// <summary>
    /// Test whether Organization should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOrganization()
    {
        return (_organization != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current DestinationType object into an XML string
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
    /// Deserializes workflow markup into an DestinationType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output DestinationType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out DestinationType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(DestinationType);
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
    
    public static bool Deserialize(string input, out DestinationType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static DestinationType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((DestinationType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static DestinationType Deserialize(System.IO.Stream s)
    {
        return ((DestinationType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current DestinationType object into file
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
    /// Deserializes xml markup from file into an DestinationType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output DestinationType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out DestinationType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(DestinationType);
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
    
    public static bool LoadFromFile(string fileName, out DestinationType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out DestinationType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static DestinationType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static DestinationType LoadFromFile(string fileName, System.Text.Encoding encoding)
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