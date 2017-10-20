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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
public partial class float_DEtype : float_Stype
{
    
    private bool _shouldSerializemaxExclusive;
    
    private bool _shouldSerializeminExclusive;
    
    private bool _shouldSerializemaxInclusive;
    
    private bool _shouldSerializeminInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<float> _minInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<float> _maxInclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<float> _minExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<float> _maxExclusive;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _fractionDigits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<byte> _totalDigits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _mask;
    
    private static XmlSerializer serializer;
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual float minInclusive
    {
        get
        {
            if (this._minInclusive.HasValue)
            {
                return this._minInclusive.Value;
            }
            else
            {
                return default(float);
            }
        }
        set
        {
            this._minInclusive = value;
            _shouldSerializeminInclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool minInclusiveSpecified
    {
        get
        {
            return this._minInclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._minInclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual float maxInclusive
    {
        get
        {
            if (this._maxInclusive.HasValue)
            {
                return this._maxInclusive.Value;
            }
            else
            {
                return default(float);
            }
        }
        set
        {
            this._maxInclusive = value;
            _shouldSerializemaxInclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool maxInclusiveSpecified
    {
        get
        {
            return this._maxInclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._maxInclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual float minExclusive
    {
        get
        {
            if (this._minExclusive.HasValue)
            {
                return this._minExclusive.Value;
            }
            else
            {
                return default(float);
            }
        }
        set
        {
            this._minExclusive = value;
            _shouldSerializeminExclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool minExclusiveSpecified
    {
        get
        {
            return this._minExclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._minExclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual float maxExclusive
    {
        get
        {
            if (this._maxExclusive.HasValue)
            {
                return this._maxExclusive.Value;
            }
            else
            {
                return default(float);
            }
        }
        set
        {
            this._maxExclusive = value;
            _shouldSerializemaxExclusive = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool maxExclusiveSpecified
    {
        get
        {
            return this._maxExclusive.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._maxExclusive = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual byte fractionDigits
    {
        get
        {
            if (this._fractionDigits.HasValue)
            {
                return this._fractionDigits.Value;
            }
            else
            {
                return default(byte);
            }
        }
        set
        {
            this._fractionDigits = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool fractionDigitsSpecified
    {
        get
        {
            return this._fractionDigits.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._fractionDigits = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual byte totalDigits
    {
        get
        {
            if (this._totalDigits.HasValue)
            {
                return this._totalDigits.Value;
            }
            else
            {
                return default(byte);
            }
        }
        set
        {
            this._totalDigits = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool totalDigitsSpecified
    {
        get
        {
            return this._totalDigits.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._totalDigits = null;
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string mask
    {
        get
        {
            return this._mask;
        }
        set
        {
            this._mask = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(float_DEtype));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether minInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminInclusive()
    {
        if (_shouldSerializeminInclusive)
        {
            return true;
        }
        return (_minInclusive != default(float));
    }
    
    /// <summary>
    /// Test whether maxInclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxInclusive()
    {
        if (_shouldSerializemaxInclusive)
        {
            return true;
        }
        return (_maxInclusive != default(float));
    }
    
    /// <summary>
    /// Test whether minExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminExclusive()
    {
        if (_shouldSerializeminExclusive)
        {
            return true;
        }
        return (_minExclusive != default(float));
    }
    
    /// <summary>
    /// Test whether maxExclusive should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxExclusive()
    {
        if (_shouldSerializemaxExclusive)
        {
            return true;
        }
        return (_maxExclusive != default(float));
    }
    
    /// <summary>
    /// Test whether mask should be serialized
    /// </summary>
    public virtual bool ShouldSerializemask()
    {
        return !string.IsNullOrEmpty(mask);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current float_DEtype object into an XML string
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
    /// Deserializes workflow markup into an float_DEtype object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output float_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out float_DEtype obj, out System.Exception exception)
    {
        exception = null;
        obj = default(float_DEtype);
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
    
    public static bool Deserialize(string input, out float_DEtype obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static float_DEtype Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((float_DEtype)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static float_DEtype Deserialize(System.IO.Stream s)
    {
        return ((float_DEtype)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current float_DEtype object into file
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
    /// Deserializes xml markup from file into an float_DEtype object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output float_DEtype object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out float_DEtype obj, out System.Exception exception)
    {
        exception = null;
        obj = default(float_DEtype);
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
    
    public static bool LoadFromFile(string fileName, out float_DEtype obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static float_DEtype LoadFromFile(string fileName)
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
