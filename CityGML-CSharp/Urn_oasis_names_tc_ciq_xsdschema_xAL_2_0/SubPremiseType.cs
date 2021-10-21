
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
public partial class SubPremiseType {
    
    private AddressLine[] addressLineField;
    
    private SubPremiseTypeSubPremiseName[] subPremiseNameField;
    
    private object[] itemsField;
    
    private SubPremiseTypeSubPremiseNumberPrefix[] subPremiseNumberPrefixField;
    
    private SubPremiseTypeSubPremiseNumberSuffix[] subPremiseNumberSuffixField;
    
    private BuildingNameType[] buildingNameField;
    
    private FirmType firmField;
    
    private MailStopType mailStopField;
    
    private PostalCode postalCodeField;
    
    private SubPremiseType subPremiseField;
    
    private System.Xml.XmlElement[] anyField;
    
    private string typeField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
    public AddressLine[] AddressLine {
        get {
            return this.addressLineField;
        }
        set {
            this.addressLineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubPremiseName")]
    public SubPremiseTypeSubPremiseName[] SubPremiseName {
        get {
            return this.subPremiseNameField;
        }
        set {
            this.subPremiseNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubPremiseLocation", typeof(SubPremiseTypeSubPremiseLocation))]
    [System.Xml.Serialization.XmlElementAttribute("SubPremiseNumber", typeof(SubPremiseTypeSubPremiseNumber))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubPremiseNumberPrefix")]
    public SubPremiseTypeSubPremiseNumberPrefix[] SubPremiseNumberPrefix {
        get {
            return this.subPremiseNumberPrefixField;
        }
        set {
            this.subPremiseNumberPrefixField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubPremiseNumberSuffix")]
    public SubPremiseTypeSubPremiseNumberSuffix[] SubPremiseNumberSuffix {
        get {
            return this.subPremiseNumberSuffixField;
        }
        set {
            this.subPremiseNumberSuffixField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BuildingName")]
    public BuildingNameType[] BuildingName {
        get {
            return this.buildingNameField;
        }
        set {
            this.buildingNameField = value;
        }
    }
    
    /// <remarks/>
    public FirmType Firm {
        get {
            return this.firmField;
        }
        set {
            this.firmField = value;
        }
    }
    
    /// <remarks/>
    public MailStopType MailStop {
        get {
            return this.mailStopField;
        }
        set {
            this.mailStopField = value;
        }
    }
    
    /// <remarks/>
    public PostalCode PostalCode {
        get {
            return this.postalCodeField;
        }
        set {
            this.postalCodeField = value;
        }
    }
    
    /// <remarks/>
    public SubPremiseType SubPremise {
        get {
            return this.subPremiseField;
        }
        set {
            this.subPremiseField = value;
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
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
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