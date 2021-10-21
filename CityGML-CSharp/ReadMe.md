# CityGMLSharp
The C# implementation for the citygml v3.0 specifications

## Installation:

`Install-Package CityGMLSharp -Version 0.0.1`

## Usage:
first make sure you add all the necessary namespaces for reading/writing files
<pre>
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using CityGMLSharp.Citygml.V3_0;
</pre>

### Reading From File example:
verify that you added the namespace `using CityGMLSharp.Citygml.V3_0;` at the start of the file

<pre> 
var mySerializer = new XmlSerializer(typeof(CityModelType));
using var myFileStream = new FileStream(@"..\GML_3.0_withNewFeatures.xml", FileMode.Open);
var city = (CityModelType)mySerializer.Deserialize(myFileStream);
</pre>
### Writing File example:

<pre>
 var xml = "";
 using (var sw = new StringWriter())
 {
     using (XmlWriter writer = XmlWriter.Create(sw))
     {
         mySerializer.Serialize(writer, city);
         xml = sw.ToString(); // Your XML
     }
 }
</pre>

