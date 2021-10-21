
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Initiative_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Series_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_ProductionSeries_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Sensor_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Platform_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_OtherAggregate_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_StereoMate_Type))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
public abstract partial class AbstractDS_Aggregate_Type : AbstractObject_Type {
    
    private DS_DataSet_PropertyType[] composedOfField;
    
    private MD_Metadata_PropertyType[] seriesMetadataField;
    
    private DS_Aggregate_PropertyType[] subsetField;
    
    private DS_Aggregate_PropertyType[] supersetField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("composedOf")]
    public DS_DataSet_PropertyType[] composedOf {
        get {
            return this.composedOfField;
        }
        set {
            this.composedOfField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("seriesMetadata")]
    public MD_Metadata_PropertyType[] seriesMetadata {
        get {
            return this.seriesMetadataField;
        }
        set {
            this.seriesMetadataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("subset")]
    public DS_Aggregate_PropertyType[] subset {
        get {
            return this.subsetField;
        }
        set {
            this.subsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("superset")]
    public DS_Aggregate_PropertyType[] superset {
        get {
            return this.supersetField;
        }
        set {
            this.supersetField = value;
        }
    }
}
}