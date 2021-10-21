
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
public abstract partial class IdentifiedObjectType : DefinitionType {
}
}