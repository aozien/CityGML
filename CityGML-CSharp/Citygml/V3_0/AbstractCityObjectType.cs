
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TunnelPartType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopLevelCityObjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WaterBodyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractVegetationObjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SolitaryVegetationObjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PlantCoverType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TunnelType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportationComplexType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoadType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RailwayType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReliefFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LandUseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericCityObjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherConstructionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CityObjectGroupType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CityFurnitureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSpaceBoundaryType))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingPartType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSpaceType))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgePartType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public abstract partial class AbstractCityObjectType : AbstractFeatureWithLifespanType {
    
    private RelativeToTerrainType relativeToTerrainField;
    
    private bool relativeToTerrainFieldSpecified;
    
    private RelativeToWaterType relativeToWaterField;
    
    private bool relativeToWaterFieldSpecified;
    
    private ExternalReferencePropertyType[] externalReferenceField;
    
    private AbstractCityObjectPropertyType[] generalizesToField;
    
    private AbstractCityObjectTypeAppearance[] appearanceField;
    
    private AbstractGenericAttributePropertyType[] genericAttributeField;
    
    private DynamizerPropertyType[] dynamizerField;
    
    /// <remarks/>
    public RelativeToTerrainType relativeToTerrain {
        get {
            return this.relativeToTerrainField;
        }
        set {
            this.relativeToTerrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relativeToTerrainSpecified {
        get {
            return this.relativeToTerrainFieldSpecified;
        }
        set {
            this.relativeToTerrainFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public RelativeToWaterType relativeToWater {
        get {
            return this.relativeToWaterField;
        }
        set {
            this.relativeToWaterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relativeToWaterSpecified {
        get {
            return this.relativeToWaterFieldSpecified;
        }
        set {
            this.relativeToWaterFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("externalReference")]
    public ExternalReferencePropertyType[] externalReference {
        get {
            return this.externalReferenceField;
        }
        set {
            this.externalReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("generalizesTo")]
    public AbstractCityObjectPropertyType[] generalizesTo {
        get {
            return this.generalizesToField;
        }
        set {
            this.generalizesToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("appearance")]
    public AbstractCityObjectTypeAppearance[] appearance {
        get {
            return this.appearanceField;
        }
        set {
            this.appearanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("genericAttribute")]
    public AbstractGenericAttributePropertyType[] genericAttribute {
        get {
            return this.genericAttributeField;
        }
        set {
            this.genericAttributeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dynamizer")]
    public DynamizerPropertyType[] dynamizer {
        get {
            return this.dynamizerField;
        }
        set {
            this.dynamizerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public enum RelativeToTerrainType {
    
    /// <remarks/>
    entirelyAboveTerrain,
    
    /// <remarks/>
    substantiallyAboveTerrain,
    
    /// <remarks/>
    substantiallyAboveAndBelowTerrain,
    
    /// <remarks/>
    substantiallyBelowTerrain,
    
    /// <remarks/>
    entirelyBelowTerrain,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/3.0")]
public enum RelativeToWaterType {
    
    /// <remarks/>
    entirelyAboveWaterSurface,
    
    /// <remarks/>
    substantiallyAboveWaterSurface,
    
    /// <remarks/>
    substantiallyAboveAndBelowWaterSurface,
    
    /// <remarks/>
    substantiallyBelowWaterSurface,
    
    /// <remarks/>
    entirelyBelowWaterSurface,
    
    /// <remarks/>
    temporarilyAboveAndBelowWaterSurface,
}
}