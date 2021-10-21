
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
namespace CityGMLSharp.Citygml.Construction.V3_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/construction/3.0")]
public partial class AbstractConstructionSurfacePropertyType {
    
    private AbstractConstructionSurfaceType itemField;
    
    private string nilReasonField;
    
    private string remoteSchemaField;
    
    private bool ownsField;
    
    public AbstractConstructionSurfacePropertyType() {
        this.ownsField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CeilingSurface", typeof(CeilingSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("FloorSurface", typeof(FloorSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("GroundSurface", typeof(GroundSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("InteriorWallSurface", typeof(InteriorWallSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("OuterCeilingSurface", typeof(OuterCeilingSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("OuterFloorSurface", typeof(OuterFloorSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("RoofSurface", typeof(RoofSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("WallSurface", typeof(WallSurfaceType))]
    public AbstractConstructionSurfaceType Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
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
}