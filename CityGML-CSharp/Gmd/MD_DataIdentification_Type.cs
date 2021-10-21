
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
[System.Xml.Serialization.XmlRootAttribute("MD_DataIdentification", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class MD_DataIdentification_Type : AbstractMD_Identification_Type {
    
    private MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationTypeField;
    
    private MD_Resolution_PropertyType[] spatialResolutionField;
    
    private CharacterString_PropertyType[] languageField;
    
    private MD_CharacterSetCode_PropertyType[] characterSetField;
    
    private MD_TopicCategoryCode_PropertyType[] topicCategoryField;
    
    private CharacterString_PropertyType environmentDescriptionField;
    
    private EX_Extent_PropertyType[] extentField;
    
    private CharacterString_PropertyType supplementalInformationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("spatialRepresentationType")]
    public MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationType {
        get {
            return this.spatialRepresentationTypeField;
        }
        set {
            this.spatialRepresentationTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("spatialResolution")]
    public MD_Resolution_PropertyType[] spatialResolution {
        get {
            return this.spatialResolutionField;
        }
        set {
            this.spatialResolutionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("language")]
    public CharacterString_PropertyType[] language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("characterSet")]
    public MD_CharacterSetCode_PropertyType[] characterSet {
        get {
            return this.characterSetField;
        }
        set {
            this.characterSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("topicCategory")]
    public MD_TopicCategoryCode_PropertyType[] topicCategory {
        get {
            return this.topicCategoryField;
        }
        set {
            this.topicCategoryField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType environmentDescription {
        get {
            return this.environmentDescriptionField;
        }
        set {
            this.environmentDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("extent")]
    public EX_Extent_PropertyType[] extent {
        get {
            return this.extentField;
        }
        set {
            this.extentField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType supplementalInformation {
        get {
            return this.supplementalInformationField;
        }
        set {
            this.supplementalInformationField = value;
        }
    }
}
}