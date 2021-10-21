
/**
* @author aozien
*/

// Granted under LGPL-2.0 License
// Copyright (c) 2021 Abdulrahman Zien https://github.com/aozien, files were generated based on the schema specs
 
using System;
using System.Xml.Serialization;

using CityGMLSharp.Citygml.Appearance.V3_0;
using CityGMLSharp.Gml.V3_2;
using CityGMLSharp.SamplingSpatial.V2_0;
using CityGMLSharp.Om.V2_0;
using CityGMLSharp.Gmd;
using CityGMLSharp.Gco;
using CityGMLSharp.Gss;
using CityGMLSharp.Gml;
using CityGMLSharp.Gts;
using CityGMLSharp.Gsr;
using CityGMLSharp.Citygml.Cityobjectgroup.V3_0;
using CityGMLSharp.Citygml.V3_0;
using CityGMLSharp.Tsml.V1_0;
using CityGMLSharp.Citygml.Generics.V3_0;
using CityGMLSharp.Citygml.Dynamizer.V3_0;
using CityGMLSharp.Swe.V2_0;
using CityGMLSharp.Gmlcov.V1_0;
using CityGMLSharp.Sos.V2_0;
using CityGMLSharp.Swes.V2_0;
using CityGMLSharp.Citygml.Versioning.V3_0;
using CityGMLSharp.Citygml.Waterbody.V3_0;
using CityGMLSharp.Citygml.Landuse.V3_0;
using CityGMLSharp.Citygml.Construction.V3_0;
using CityGMLSharp.Urn_oasis_names_tc_ciq_xsdschema_xAL_2_0;
using CityGMLSharp.Citygml.Transportation.V3_0;
using CityGMLSharp.Citygml.Relief.V3_0;
using CityGMLSharp.Citygml.Building.V3_0;
using CityGMLSharp.Citygml.Tunnel.V3_0;
using CityGMLSharp.Citygml.Bridge.V3_0;
using CityGMLSharp.Citygml.Vegetation.V3_0;
using CityGMLSharp.Citygml.Cityfurniture.V3_0;
using CityGMLSharp.Sampling.V2_0;
using CityGMLSharp.Addressing;
using CityGMLSharp.Fes.V2_0;
using CityGMLSharp.Ows.V1_1;
using CityGMLSharp.Wsn.T_1;
namespace CityGMLSharp.Urn_oasis_names_tc_ciq_xsdschema_xAL_2_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0", IsNullable=false)]
public partial class AddressDetails {
    
    private AddressDetailsPostalServiceElements postalServiceElementsField;
    
    private object itemField;
    
    private System.Xml.XmlElement[] anyField;
    
    private string addressTypeField;
    
    private string currentStatusField;
    
    private string validFromDateField;
    
    private string validToDateField;
    
    private string usageField;
    
    private string codeField;
    
    private string addressDetailsKeyField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    public AddressDetailsPostalServiceElements PostalServiceElements {
        get {
            return this.postalServiceElementsField;
        }
        set {
            this.postalServiceElementsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Address", typeof(AddressDetailsAddress))]
    [System.Xml.Serialization.XmlElementAttribute("AddressLines", typeof(AddressLinesType))]
    [System.Xml.Serialization.XmlElementAttribute("AdministrativeArea", typeof(AdministrativeArea))]
    [System.Xml.Serialization.XmlElementAttribute("Country", typeof(AddressDetailsCountry))]
    [System.Xml.Serialization.XmlElementAttribute("Locality", typeof(Locality))]
    [System.Xml.Serialization.XmlElementAttribute("Thoroughfare", typeof(Thoroughfare))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AddressType {
        get {
            return this.addressTypeField;
        }
        set {
            this.addressTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CurrentStatus {
        get {
            return this.currentStatusField;
        }
        set {
            this.currentStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValidFromDate {
        get {
            return this.validFromDateField;
        }
        set {
            this.validFromDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValidToDate {
        get {
            return this.validToDateField;
        }
        set {
            this.validToDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Usage {
        get {
            return this.usageField;
        }
        set {
            this.usageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AddressDetailsKey {
        get {
            return this.addressDetailsKeyField;
        }
        set {
            this.addressDetailsKeyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}
}