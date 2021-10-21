
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="DefinitionBaseType", Namespace="http://www.opengis.net/gml")]
public partial class DefinitionBaseType1 : AbstractGMLType1 {
}
}