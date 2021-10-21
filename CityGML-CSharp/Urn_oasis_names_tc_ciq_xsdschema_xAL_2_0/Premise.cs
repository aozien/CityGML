
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0", IsNullable=false)]
public partial class Premise {
    
    private AddressLine[] addressLineField;
    
    private PremisePremiseName[] premiseNameField;
    
    private object[] itemsField;
    
    private PremiseNumberPrefix[] premiseNumberPrefixField;
    
    private PremiseNumberSuffix[] premiseNumberSuffixField;
    
    private BuildingNameType[] buildingNameField;
    
    private object[] items1Field;
    
    private MailStopType mailStopField;
    
    private PostalCode postalCodeField;
    
    private Premise premise1Field;
    
    private System.Xml.XmlElement[] anyField;
    
    private string typeField;
    
    private string premiseDependencyField;
    
    private string premiseDependencyTypeField;
    
    private string premiseThoroughfareConnectorField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("PremiseName")]
    public PremisePremiseName[] PremiseName {
        get {
            return this.premiseNameField;
        }
        set {
            this.premiseNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PremiseLocation", typeof(PremisePremiseLocation))]
    [System.Xml.Serialization.XmlElementAttribute("PremiseNumber", typeof(PremiseNumber))]
    [System.Xml.Serialization.XmlElementAttribute("PremiseNumberRange", typeof(PremisePremiseNumberRange))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PremiseNumberPrefix")]
    public PremiseNumberPrefix[] PremiseNumberPrefix {
        get {
            return this.premiseNumberPrefixField;
        }
        set {
            this.premiseNumberPrefixField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PremiseNumberSuffix")]
    public PremiseNumberSuffix[] PremiseNumberSuffix {
        get {
            return this.premiseNumberSuffixField;
        }
        set {
            this.premiseNumberSuffixField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("Firm", typeof(FirmType))]
    [System.Xml.Serialization.XmlElementAttribute("SubPremise", typeof(SubPremiseType))]
    public object[] Items1 {
        get {
            return this.items1Field;
        }
        set {
            this.items1Field = value;
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
    [System.Xml.Serialization.XmlElementAttribute("Premise")]
    public Premise Premise1 {
        get {
            return this.premise1Field;
        }
        set {
            this.premise1Field = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PremiseDependency {
        get {
            return this.premiseDependencyField;
        }
        set {
            this.premiseDependencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PremiseDependencyType {
        get {
            return this.premiseDependencyTypeField;
        }
        set {
            this.premiseDependencyTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PremiseThoroughfareConnector {
        get {
            return this.premiseThoroughfareConnectorField;
        }
        set {
            this.premiseThoroughfareConnectorField = value;
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