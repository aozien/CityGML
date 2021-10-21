
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
namespace CityGMLSharp.Tsml.V1_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/tsml/1.0")]
public partial class SamplingFeatureMemberPropertyType {
    
    private SF_SpatialSamplingFeatureType sF_SpatialSamplingFeatureField;
    
    private SF_SamplingFeatureCollectionType sF_SamplingFeatureCollectionField;
    
    private string nilReasonField;
    
    private string remoteSchemaField;
    
    private SamplingFeatureMemberUnionSemantics unionSemanticsField;
    
    private bool unionSemanticsFieldSpecified;
    
    private bool ownsField;
    
    public SamplingFeatureMemberPropertyType() {
        this.ownsField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/samplingSpatial/2.0")]
    public SF_SpatialSamplingFeatureType SF_SpatialSamplingFeature {
        get {
            return this.sF_SpatialSamplingFeatureField;
        }
        set {
            this.sF_SpatialSamplingFeatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/sampling/2.0")]
    public SF_SamplingFeatureCollectionType SF_SamplingFeatureCollection {
        get {
            return this.sF_SamplingFeatureCollectionField;
        }
        set {
            this.sF_SamplingFeatureCollectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nilReason {
        get {
            return this.nilReasonField;
        }
        set {
            this.nilReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
    public string remoteSchema {
        get {
            return this.remoteSchemaField;
        }
        set {
            this.remoteSchemaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SamplingFeatureMemberUnionSemantics unionSemantics {
        get {
            return this.unionSemanticsField;
        }
        set {
            this.unionSemanticsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool unionSemanticsSpecified {
        get {
            return this.unionSemanticsFieldSpecified;
        }
        set {
            this.unionSemanticsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns {
        get {
            return this.ownsField;
        }
        set {
            this.ownsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/tsml/1.0")]
public enum SamplingFeatureMemberUnionSemantics {
    
    /// <remarks/>
    byFeature,
    
    /// <remarks/>
    byGroup,
}
}