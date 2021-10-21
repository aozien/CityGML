
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
[System.Xml.Serialization.XmlRootAttribute("LI_Source", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class LI_Source_Type : AbstractObject_Type {
    
    private CharacterString_PropertyType descriptionField;
    
    private MD_RepresentativeFraction_PropertyType scaleDenominatorField;
    
    private MD_ReferenceSystem_PropertyType sourceReferenceSystemField;
    
    private CI_Citation_PropertyType sourceCitationField;
    
    private EX_Extent_PropertyType[] sourceExtentField;
    
    private LI_ProcessStep_PropertyType[] sourceStepField;
    
    /// <remarks/>
    public CharacterString_PropertyType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public MD_RepresentativeFraction_PropertyType scaleDenominator {
        get {
            return this.scaleDenominatorField;
        }
        set {
            this.scaleDenominatorField = value;
        }
    }
    
    /// <remarks/>
    public MD_ReferenceSystem_PropertyType sourceReferenceSystem {
        get {
            return this.sourceReferenceSystemField;
        }
        set {
            this.sourceReferenceSystemField = value;
        }
    }
    
    /// <remarks/>
    public CI_Citation_PropertyType sourceCitation {
        get {
            return this.sourceCitationField;
        }
        set {
            this.sourceCitationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sourceExtent")]
    public EX_Extent_PropertyType[] sourceExtent {
        get {
            return this.sourceExtentField;
        }
        set {
            this.sourceExtentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sourceStep")]
    public LI_ProcessStep_PropertyType[] sourceStep {
        get {
            return this.sourceStepField;
        }
        set {
            this.sourceStepField = value;
        }
    }
}
}