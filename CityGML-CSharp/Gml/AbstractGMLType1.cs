
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArrayType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopologyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoComplexType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoVolumeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoCurveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoPointType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopoPrimitiveType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeValueType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeSliceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MovingObjectStatusType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ObservationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType2))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContinuousCoverageType2))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDiscreteCoverageType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureCollectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundedFeatureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeObjectType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeComplexType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeTopologyComplexType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeTopologyPrimitiveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionBaseType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalEraType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarEraType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeReferenceSystemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AffineCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralOperationParameterType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeocentricCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitDefinitionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConventionalUnitType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedUnitType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionProxyType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DictionaryType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometryType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GridType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricComplexType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricAggregateType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BagType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractGMLType", Namespace="http://www.opengis.net/gml")]
public abstract partial class AbstractGMLType1 {
    
    private MetaDataPropertyType1[] metaDataPropertyField;
    
    private StringOrRefType1 descriptionField;
    
    private ReferenceType1 descriptionReferenceField;
    
    private CodeWithAuthorityType1 identifierField;
    
    private CodeType1[] nameField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("metaDataProperty")]
    public MetaDataPropertyType1[] metaDataProperty {
        get {
            return this.metaDataPropertyField;
        }
        set {
            this.metaDataPropertyField = value;
        }
    }
    
    /// <remarks/>
    public StringOrRefType1 description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType1 descriptionReference {
        get {
            return this.descriptionReferenceField;
        }
        set {
            this.descriptionReferenceField = value;
        }
    }
    
    /// <remarks/>
    public CodeWithAuthorityType1 identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("name")]
    public CodeType1[] name {
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