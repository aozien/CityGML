
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryTrafficSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractUnoccupiedSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(HollowSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportationSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TrafficSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(HoleType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoadwayDamageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ManholeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DrainType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ClearanceSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericUnoccupiedSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractVoidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractConstructionVoidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WindowType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DoorType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoomType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgeRoomType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractOccupiedSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WaterSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VegetationSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericOccupiedSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstructionSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractInstallationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TunnelInstallationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingInstallationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgeInstallationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFurnitureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TunnelFurnitureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingFurnitureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgeFurnitureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractConstructiveElementType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TunnelConstructiveElementType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingConstructiveElementType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgeConstructionElementType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FurnitureSpaceType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public abstract partial class AbstractPhysicalSpaceType : AbstractSpaceType {
    
    private MultiCurvePropertyType lod1TerrainIntersectionCurveField;
    
    private MultiCurvePropertyType lod2TerrainIntersectionCurveField;
    
    private MultiCurvePropertyType lod3TerrainIntersectionCurveField;
    
    private PointCloudPropertyType pointCloudField;
    
    /// <remarks/>
    public MultiCurvePropertyType lod1TerrainIntersectionCurve {
        get {
            return this.lod1TerrainIntersectionCurveField;
        }
        set {
            this.lod1TerrainIntersectionCurveField = value;
        }
    }
    
    /// <remarks/>
    public MultiCurvePropertyType lod2TerrainIntersectionCurve {
        get {
            return this.lod2TerrainIntersectionCurveField;
        }
        set {
            this.lod2TerrainIntersectionCurveField = value;
        }
    }
    
    /// <remarks/>
    public MultiCurvePropertyType lod3TerrainIntersectionCurve {
        get {
            return this.lod3TerrainIntersectionCurveField;
        }
        set {
            this.lod3TerrainIntersectionCurveField = value;
        }
    }
    
    /// <remarks/>
    public PointCloudPropertyType pointCloud {
        get {
            return this.pointCloudField;
        }
        set {
            this.pointCloudField = value;
        }
    }
}
}