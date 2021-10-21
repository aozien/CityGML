
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
namespace CityGMLSharp.Gmd
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ServiceIdentification_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_DataIdentification_Type))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
public abstract partial class AbstractMD_Identification_Type : AbstractObject_Type {
    
    private CI_Citation_PropertyType citationField;
    
    private CharacterString_PropertyType abstractField;
    
    private CharacterString_PropertyType purposeField;
    
    private CharacterString_PropertyType[] creditField;
    
    private MD_ProgressCode_PropertyType[] statusField;
    
    private CI_ResponsibleParty_PropertyType[] pointOfContactField;
    
    private MD_MaintenanceInformation_PropertyType[] resourceMaintenanceField;
    
    private MD_BrowseGraphic_PropertyType[] graphicOverviewField;
    
    private MD_Format_PropertyType[] resourceFormatField;
    
    private MD_Keywords_PropertyType[] descriptiveKeywordsField;
    
    private MD_Usage_PropertyType[] resourceSpecificUsageField;
    
    private MD_Constraints_PropertyType[] resourceConstraintsField;
    
    private MD_AggregateInformation_PropertyType[] aggregationInfoField;
    
    /// <remarks/>
    public CI_Citation_PropertyType citation {
        get {
            return this.citationField;
        }
        set {
            this.citationField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType @abstract {
        get {
            return this.abstractField;
        }
        set {
            this.abstractField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType purpose {
        get {
            return this.purposeField;
        }
        set {
            this.purposeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("credit")]
    public CharacterString_PropertyType[] credit {
        get {
            return this.creditField;
        }
        set {
            this.creditField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("status")]
    public MD_ProgressCode_PropertyType[] status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("pointOfContact")]
    public CI_ResponsibleParty_PropertyType[] pointOfContact {
        get {
            return this.pointOfContactField;
        }
        set {
            this.pointOfContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resourceMaintenance")]
    public MD_MaintenanceInformation_PropertyType[] resourceMaintenance {
        get {
            return this.resourceMaintenanceField;
        }
        set {
            this.resourceMaintenanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("graphicOverview")]
    public MD_BrowseGraphic_PropertyType[] graphicOverview {
        get {
            return this.graphicOverviewField;
        }
        set {
            this.graphicOverviewField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resourceFormat")]
    public MD_Format_PropertyType[] resourceFormat {
        get {
            return this.resourceFormatField;
        }
        set {
            this.resourceFormatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("descriptiveKeywords")]
    public MD_Keywords_PropertyType[] descriptiveKeywords {
        get {
            return this.descriptiveKeywordsField;
        }
        set {
            this.descriptiveKeywordsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resourceSpecificUsage")]
    public MD_Usage_PropertyType[] resourceSpecificUsage {
        get {
            return this.resourceSpecificUsageField;
        }
        set {
            this.resourceSpecificUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resourceConstraints")]
    public MD_Constraints_PropertyType[] resourceConstraints {
        get {
            return this.resourceConstraintsField;
        }
        set {
            this.resourceConstraintsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("aggregationInfo")]
    public MD_AggregateInformation_PropertyType[] aggregationInfo {
        get {
            return this.aggregationInfoField;
        }
        set {
            this.aggregationInfoField = value;
        }
    }
}
}