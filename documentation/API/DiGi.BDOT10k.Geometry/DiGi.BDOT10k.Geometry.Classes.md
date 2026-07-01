#### [DiGi\.BDOT10k\.Geometry](index.md 'index')

## DiGi\.BDOT10k\.Geometry\.Classes Namespace
### Classes

<a name='DiGi.BDOT10k.Geometry.Classes.ADMS_A'></a>

## ADMS\_A Class

Reprezentuje powierzchniowy obiekt geometryczny typu ADMS\_A zgodnie ze standardem BDOT10k\.

```csharp
public class ADMS_A : DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny<DiGi.BDOT10k.Classes.OT_ADMS_A>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2') → [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.classes.visualpolygonalface2d 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D') → [DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny&lt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>')[DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adms_a 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')[&gt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>') → ADMS\_A
### Constructors

<a name='DiGi.BDOT10k.Geometry.Classes.ADMS_A.ADMS_A(DiGi.BDOT10k.Classes.OT_ADMS_A,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance)'></a>

## ADMS\_A\(OT\_ADMS\_A, ISurfaceAppearance\) Constructor

Inicjalizuje nową instancję klasy [ADMS\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.ADMS_A 'DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A')\.

```csharp
public ADMS_A(DiGi.BDOT10k.Classes.OT_ADMS_A? oT_PowierzchniowyObiektGeometryczny, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance? surfaceAppearance);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Classes.ADMS_A.ADMS_A(DiGi.BDOT10k.Classes.OT_ADMS_A,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).oT_PowierzchniowyObiektGeometryczny'></a>

`oT_PowierzchniowyObiektGeometryczny` [DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_adms_a 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')

Obiekt danych wejściowych dla obiektu powierzchniowego\.

<a name='DiGi.BDOT10k.Geometry.Classes.ADMS_A.ADMS_A(DiGi.BDOT10k.Classes.OT_ADMS_A,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).surfaceAppearance'></a>

`surfaceAppearance` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

Wygląd powierzchni obiektu\.
### Properties

<a name='DiGi.BDOT10k.Geometry.Classes.ADMS_A.liczbaMieszkancow'></a>

## ADMS\_A\.liczbaMieszkancow Property

Pobiera liczbę mieszkańców przypisaną do danego obiektu\.

```csharp
public System.Nullable<uint> liczbaMieszkancow { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
Liczba mieszkańców jako wartość typu uint lub null, jeśli nie jest określona\.

<a name='DiGi.BDOT10k.Geometry.Classes.BUBD_A'></a>

## BUBD\_A Class

Reprezentuje obiekt geometryczny powierzchniowy typu BUBD\_A w standardzie BDOT10k\.

```csharp
public class BUBD_A : DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny<DiGi.BDOT10k.Classes.OT_BUBD_A>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2') → [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.classes.visualpolygonalface2d 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D') → [DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny&lt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>')[DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_bubd_a 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')[&gt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>') → BUBD\_A
### Constructors

<a name='DiGi.BDOT10k.Geometry.Classes.BUBD_A.BUBD_A(DiGi.BDOT10k.Classes.OT_BUBD_A,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance)'></a>

## BUBD\_A\(OT\_BUBD\_A, ISurfaceAppearance\) Constructor

Inicjalizuje nową instancję klasy [BUBD\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.BUBD_A 'DiGi\.BDOT10k\.Geometry\.Classes\.BUBD\_A')\.

```csharp
public BUBD_A(DiGi.BDOT10k.Classes.OT_BUBD_A? oT_PowierzchniowyObiektGeometryczny, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance? surfaceAppearance);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Classes.BUBD_A.BUBD_A(DiGi.BDOT10k.Classes.OT_BUBD_A,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).oT_PowierzchniowyObiektGeometryczny'></a>

`oT_PowierzchniowyObiektGeometryczny` [DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.classes.ot_bubd_a 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')

Obiekt danych wejściowych dla powierzchniowego obiektu geometrycznego\.

<a name='DiGi.BDOT10k.Geometry.Classes.BUBD_A.BUBD_A(DiGi.BDOT10k.Classes.OT_BUBD_A,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).surfaceAppearance'></a>

`surfaceAppearance` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

Wygląd powierzchni obiektu\.

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_'></a>

## PowierzchniowyObiektGeometryczny\<T\> Class

Represents an abstract surface geometric object in the BDOT10k standard\.

```csharp
public abstract class PowierzchniowyObiektGeometryczny<T> : DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D, DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny<DiGi.Geometry.Planar.Classes.PolygonalFace2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Classes.PolygonalFace2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Classes.PolygonalFace2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Classes.PolygonalFace2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Classes.PolygonalFace2D>
    where T : DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny
```
#### Type parameters

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.T'></a>

`T`

The type of the input data object implementing the [DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.interfaces.iot_powierzchniowyobiektgeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny') interface\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2') → [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.classes.visualpolygonalface2d 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D') → PowierzchniowyObiektGeometryczny\<T\>

Derived  
↳ [ADMS\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.ADMS_A 'DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A')  
↳ [BUBD\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.BUBD_A 'DiGi\.BDOT10k\.Geometry\.Classes\.BUBD\_A')

Implements [DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny&lt;](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_ 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_ 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_ 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>'), [IObiektGeometryczny](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d-2 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d-2 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\`2')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d-2 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\`2'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual-2 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual-2 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\`2')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual-2 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\`2'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.PowierzchniowyObiektGeometryczny(T,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance)'></a>

## PowierzchniowyObiektGeometryczny\(T, ISurfaceAppearance\) Constructor

Initializes a new instance of the [PowierzchniowyObiektGeometryczny&lt;T&gt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>') class\.

```csharp
public PowierzchniowyObiektGeometryczny(T? oT_PowierzchniowyObiektGeometryczny, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance? surfaceAppearance);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.PowierzchniowyObiektGeometryczny(T,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).oT_PowierzchniowyObiektGeometryczny'></a>

`oT_PowierzchniowyObiektGeometryczny` [T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.T 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>\.T')

The input data object containing the surface geometry\.

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.PowierzchniowyObiektGeometryczny(T,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).surfaceAppearance'></a>

`surfaceAppearance` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.isurfaceappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

The surface appearance of the object\.
### Properties

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.Area'></a>

## PowierzchniowyObiektGeometryczny\<T\>\.Area Property

Gets the area of the geometric object\.

```csharp
public double Area { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.BoundingBox2D'></a>

## PowierzchniowyObiektGeometryczny\<T\>\.BoundingBox2D Property

Gets the bounding box of the object in 2D space\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox2D { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.InternalPoint2D'></a>

## PowierzchniowyObiektGeometryczny\<T\>\.InternalPoint2D Property

Gets the internal point of the geometric object\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? InternalPoint2D { get; }
```

#### Property Value
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.OT_PowierzchniowyObiektGeometryczny'></a>

## PowierzchniowyObiektGeometryczny\<T\>\.OT\_PowierzchniowyObiektGeometryczny Property

Gets a clone of the input data object associated with this geometric object\.

```csharp
public T? OT_PowierzchniowyObiektGeometryczny { get; }
```

#### Property Value
[T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.T 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>\.T')
### Methods

<a name='DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_.GetUnderlyingType()'></a>

## PowierzchniowyObiektGeometryczny\<T\>\.GetUnderlyingType\(\) Method

Gets the type of the input data object associated with this geometric object\.

```csharp
public System.Type? GetUnderlyingType();
```

Implements [GetUnderlyingType\(\)](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny.GetUnderlyingType() 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\.GetUnderlyingType\(\)')

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The type of the input data object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the object is not assigned\.

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych'></a>

## SlownikObiektowGeometrycznych Class

Klasa reprezentująca słownik obiektów geometrycznych, umożliwiający przechowywanie i wyszukiwanie obiektów według ich typu\.

```csharp
public class SlownikObiektowGeometrycznych
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SlownikObiektowGeometrycznych
### Constructors

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.SlownikObiektowGeometrycznych()'></a>

## SlownikObiektowGeometrycznych\(\) Constructor

Inicjalizuje nową instancję klasy [SlownikObiektowGeometrycznych](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych')\.

```csharp
public SlownikObiektowGeometrycznych();
```
### Methods

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.Add(DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny)'></a>

## SlownikObiektowGeometrycznych\.Add\(IObiektGeometryczny\) Method

Dodaje obiekt geometryczny do słownika, grupując go według jego typu\.

```csharp
public bool Add(DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny obiektGeometryczny);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.Add(DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny).obiektGeometryczny'></a>

`obiektGeometryczny` [IObiektGeometryczny](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny')

Obiekt geometryczny do dodania\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Wartość [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), jeśli obiekt został pomyślnie dodany; w przeciwnym razie [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') \(np\. gdy przekazano wartość [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\)\.

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_)'></a>

## SlownikObiektowGeometrycznych\.GetObiektGeometryczny\<T\>\(Func\<T,bool\>\) Method

Pobiera pierwszy znaleziony obiekt geometryczny danego typu, który spełnia określone kryterium filtrowania\.

```csharp
public T? GetObiektGeometryczny<T>(System.Func<T,bool>? func=null)
    where T : DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny;
```
#### Type parameters

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).T'></a>

`T`

Typ obiektu geometrycznego, który ma zostać pobrany\.
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektGeometryczny\<T\>\(System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

Opcjonalna funkcja filtrująca obiekty typu [T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektGeometryczny\<T\>\(System\.Func\<T,bool\>\)\.T')\.

#### Returns
[T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektGeometryczny\<T\>\(System\.Func\<T,bool\>\)\.T')  
Obiekt typu [T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektGeometryczny\<T\>\(System\.Func\<T,bool\>\)\.T') spełniający kryteria lub wartość domyślna dla typu [T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektGeometryczny_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektGeometryczny\<T\>\(System\.Func\<T,bool\>\)\.T'), jeśli nie znaleziono pasującego obiektu\.

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_)'></a>

## SlownikObiektowGeometrycznych\.GetObiektyGeometryczne\<T\>\(Func\<T,bool\>\) Method

Pobiera listę wszystkich obiektów geometrycznych danego typu, które spełniają określone kryterium filtrowania\.

```csharp
public System.Collections.Generic.List<T>? GetObiektyGeometryczne<T>(System.Func<T,bool>? func=null)
    where T : DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny;
```
#### Type parameters

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_).T'></a>

`T`

Typ obiektu geometrycznego, który ma zostać pobrany\.
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektyGeometryczne\<T\>\(System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

Opcjonalna funkcja filtrująca obiekty typu [T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektyGeometryczne\<T\>\(System\.Func\<T,bool\>\)\.T')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektyGeometryczne\<T\>\(System\.Func\<T,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
Lista obiektów typu [T](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych.GetObiektyGeometryczne_T_(System.Func_T,bool_).T 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych\.GetObiektyGeometryczne\<T\>\(System\.Func\<T,bool\>\)\.T') spełniających kryteria lub [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), jeśli słownik jest nieprawidłowy\.