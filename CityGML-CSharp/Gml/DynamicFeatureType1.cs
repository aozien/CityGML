
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
namespace CityGMLSharp.Gml
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType1))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="DynamicFeatureType", Namespace="http://www.opengis.net/gml")]
[System.Xml.Serialization.XmlRootAttribute("DynamicFeature", Namespace="http://www.opengis.net/gml", IsNullable=false)]
public partial class DynamicFeatureType1 : AbstractFeatureType1 {
    
    private TimePrimitivePropertyType1 validTimeField;
    
    private HistoryPropertyType1 historyField;
    
    private StringOrRefType1 dataSourceField;
    
    private ReferenceType1 dataSourceReferenceField;
    
    /// <remarks/>
    public TimePrimitivePropertyType1 validTime {
        get {
            return this.validTimeField;
        }
        set {
            this.validTimeField = value;
        }
    }
    
    /// <remarks/>
    public HistoryPropertyType1 history {
        get {
            return this.historyField;
        }
        set {
            this.historyField = value;
        }
    }
    
    /// <remarks/>
    public StringOrRefType1 dataSource {
        get {
            return this.dataSourceField;
        }
        set {
            this.dataSourceField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType1 dataSourceReference {
        get {
            return this.dataSourceReferenceField;
        }
        set {
            this.dataSourceReferenceField = value;
        }
    }
}
}