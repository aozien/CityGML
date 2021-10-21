
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
namespace CityGMLSharp.Gml.V3_2
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArrayType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BagType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopologyType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoComplexType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoVolumeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoPointType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopoPrimitiveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoleType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSpaceRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologicSpaceRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ThematicSpaceRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericSpaceRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricSpaceRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeseriesTVPType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeSliceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MovingObjectStatusType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeObjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeComplexType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeTopologyComplexType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeTopologyPrimitiveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePositionListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalEraType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarEraType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeReferenceSystemType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralOperationParameterType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AffineCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeocentricCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitDefinitionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConventionalUnitType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedUnitType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionProxyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DictionaryType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometryType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GridType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReferenceableGridType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricComplexType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricAggregateType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleMultiPointType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSolidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureCollectionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundedFeatureType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ObservationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SF_SamplingFeatureCollectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CollectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SF_SamplingFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SF_SpatialSamplingFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MonitoringFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ObservationProcessType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplicitGeometryType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PointCloudType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeseriesComponentType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OM_ObservationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContinuousCoverageType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscreteCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContinuousCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDiscreteCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeseriesDomainRangeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnnotationCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeseriesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeTimeseriesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AtomicTimeseriesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureWithLifespanType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VersionTransitionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VersionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CityModelType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamizerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCityObjectType))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AppearanceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceDataType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(X3DMaterialType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTextureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterizedTextureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoreferencedTextureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractBoundaryRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologicBoundaryRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ThematicBoundaryRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericBoundaryRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricBoundaryRelationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoomHeightType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TextureAssociationType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
public abstract partial class AbstractGMLType {
    
    private MetaDataPropertyType[] metaDataPropertyField;
    
    private StringOrRefType descriptionField;
    
    private ReferenceType descriptionReferenceField;
    
    private CodeWithAuthorityType identifierField;
    
    private CodeType[] nameField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("metaDataProperty")]
    public MetaDataPropertyType[] metaDataProperty {
        get {
            return this.metaDataPropertyField;
        }
        set {
            this.metaDataPropertyField = value;
        }
    }
    
    /// <remarks/>
    public StringOrRefType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType descriptionReference {
        get {
            return this.descriptionReferenceField;
        }
        set {
            this.descriptionReferenceField = value;
        }
    }
    
    /// <remarks/>
    public CodeWithAuthorityType identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("name")]
    public CodeType[] name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}
}