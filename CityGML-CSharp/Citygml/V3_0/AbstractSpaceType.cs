
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractPhysicalSpaceType))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractLogicalSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericLogicalSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupSpaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractBuildingSubdivisionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StoreyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingUnitType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public abstract partial class AbstractSpaceType : AbstractCityObjectType {
    
    private string occupancyDaytimeField;
    
    private string occupancyNighttimeField;
    
    private SpaceTypeType spaceTypeField;
    
    private bool spaceTypeFieldSpecified;
    
    private AbstractSpaceBoundaryPropertyType[] boundaryField;
    
    private AbstractSpaceRelationPropertyType[] spaceRelationField;
    
    private PointPropertyType lod0PointField;
    
    private MultiSurfacePropertyType lod0MultiSurfaceField;
    
    private SolidPropertyType lod1SolidField;
    
    private MultiSurfacePropertyType lod2MultiSurfaceField;
    
    private SolidPropertyType lod2SolidField;
    
    private MultiCurvePropertyType lod2MultiCurveField;
    
    private MultiSurfacePropertyType lod3MultiSurfaceField;
    
    private SolidPropertyType lod3SolidField;
    
    private MultiCurvePropertyType lod3MultiCurveField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string occupancyDaytime {
        get {
            return this.occupancyDaytimeField;
        }
        set {
            this.occupancyDaytimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string occupancyNighttime {
        get {
            return this.occupancyNighttimeField;
        }
        set {
            this.occupancyNighttimeField = value;
        }
    }
    
    /// <remarks/>
    public SpaceTypeType spaceType {
        get {
            return this.spaceTypeField;
        }
        set {
            this.spaceTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool spaceTypeSpecified {
        get {
            return this.spaceTypeFieldSpecified;
        }
        set {
            this.spaceTypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boundary")]
    public AbstractSpaceBoundaryPropertyType[] boundary {
        get {
            return this.boundaryField;
        }
        set {
            this.boundaryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("spaceRelation")]
    public AbstractSpaceRelationPropertyType[] spaceRelation {
        get {
            return this.spaceRelationField;
        }
        set {
            this.spaceRelationField = value;
        }
    }
    
    /// <remarks/>
    public PointPropertyType lod0Point {
        get {
            return this.lod0PointField;
        }
        set {
            this.lod0PointField = value;
        }
    }
    
    /// <remarks/>
    public MultiSurfacePropertyType lod0MultiSurface {
        get {
            return this.lod0MultiSurfaceField;
        }
        set {
            this.lod0MultiSurfaceField = value;
        }
    }
    
    /// <remarks/>
    public SolidPropertyType lod1Solid {
        get {
            return this.lod1SolidField;
        }
        set {
            this.lod1SolidField = value;
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
    public SolidPropertyType lod2Solid {
        get {
            return this.lod2SolidField;
        }
        set {
            this.lod2SolidField = value;
        }
    }
    
    /// <remarks/>
    public MultiCurvePropertyType lod2MultiCurve {
        get {
            return this.lod2MultiCurveField;
        }
        set {
            this.lod2MultiCurveField = value;
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
    
    /// <remarks/>
    public SolidPropertyType lod3Solid {
        get {
            return this.lod3SolidField;
        }
        set {
            this.lod3SolidField = value;
        }
    }
    
    /// <remarks/>
    public MultiCurvePropertyType lod3MultiCurve {
        get {
            return this.lod3MultiCurveField;
        }
        set {
            this.lod3MultiCurveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public enum SpaceTypeType {
    
    /// <remarks/>
    closed,
    
    /// <remarks/>
    open,
    
    /// <remarks/>
    semiOpen,
}
}