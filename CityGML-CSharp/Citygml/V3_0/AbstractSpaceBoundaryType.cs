
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
namespace CityGMLSharp.Citygml.V3_0
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LandUseAreaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ClosureSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractVoidSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractConstructionOpeningSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WindowSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DoorSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractThematicSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractWaterBoundarySurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WaterSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WaterGroundSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WaterClosureSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TrafficAreaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryTrafficAreaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericThematicSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractConstructionSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WallSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoofSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OuterFloorSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OuterCeilingSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InteriorWallSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GroundSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FloorSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CeilingSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReliefSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReliefComponentType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TINReliefType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RasterReliefType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MassPointReliefType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BreaklineReliefType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public abstract partial class AbstractSpaceBoundaryType : AbstractCityObjectType {
    
    private AbstractSpacePropertyType[] boundsField;
    
    private AbstractBoundaryRelationPropertyType[] boundaryRelationField;
    
    private MultiCurvePropertyType lod0MultiCurveField;
    
    private MultiSurfacePropertyType lod1MultiSurfaceField;
    
    private MultiSurfacePropertyType lod2MultiSurfaceField;
    
    private MultiSurfacePropertyType lod3MultiSurfaceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bounds")]
    public AbstractSpacePropertyType[] bounds {
        get {
            return this.boundsField;
        }
        set {
            this.boundsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boundaryRelation")]
    public AbstractBoundaryRelationPropertyType[] boundaryRelation {
        get {
            return this.boundaryRelationField;
        }
        set {
            this.boundaryRelationField = value;
        }
    }
    
    /// <remarks/>
    public MultiCurvePropertyType lod0MultiCurve {
        get {
            return this.lod0MultiCurveField;
        }
        set {
            this.lod0MultiCurveField = value;
        }
    }
    
    /// <remarks/>
    public MultiSurfacePropertyType lod1MultiSurface {
        get {
            return this.lod1MultiSurfaceField;
        }
        set {
            this.lod1MultiSurfaceField = value;
        }
    }
    
    /// <remarks/>
    public MultiSurfacePropertyType lod2MultiSurface {
        get {
            return this.lod2MultiSurfaceField;
        }
        set {
            this.lod2MultiSurfaceField = value;
        }
    }
    
    /// <remarks/>
    public MultiSurfacePropertyType lod3MultiSurface {
        get {
            return this.lod3MultiSurfaceField;
        }
        set {
            this.lod3MultiSurfaceField = value;
        }
    }
}
}