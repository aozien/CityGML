
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
namespace CityGMLSharp.SamplingSpatial.V2_0
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MonitoringFeatureType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/samplingSpatial/2.0")]
[System.Xml.Serialization.XmlRootAttribute("SF_SpatialSamplingFeature", Namespace="http://www.opengis.net/samplingSpatial/2.0", IsNullable=false)]
public partial class SF_SpatialSamplingFeatureType : SF_SamplingFeatureType {
    
    private OM_ProcessPropertyType[] hostedProcedureField;
    
    private DQ_PositionalAccuracy_PropertyType[] positionalAccuracyField;
    
    private shapeType shapeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hostedProcedure")]
    public OM_ProcessPropertyType[] hostedProcedure {
        get {
            return this.hostedProcedureField;
        }
        set {
            this.hostedProcedureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("positionalAccuracy")]
    public DQ_PositionalAccuracy_PropertyType[] positionalAccuracy {
        get {
            return this.positionalAccuracyField;
        }
        set {
            this.positionalAccuracyField = value;
        }
    }
    
    /// <remarks/>
    public shapeType shape {
        get {
            return this.shapeField;
        }
        set {
            this.shapeField = value;
        }
    }
}
}