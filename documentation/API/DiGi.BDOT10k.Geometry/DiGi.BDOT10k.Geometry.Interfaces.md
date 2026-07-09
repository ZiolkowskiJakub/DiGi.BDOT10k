#### [DiGi\.BDOT10k\.Geometry](DiGi.BDOT10k.Geometry.Overview.md 'DiGi\.BDOT10k\.Geometry\.Overview')

## DiGi\.BDOT10k\.Geometry\.Interfaces Namespace
### Interfaces

<a name='DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny'></a>

## IObiektGeometryczny Interface

Definiuje podstawowy interfejs dla obiektów geometrycznych w systemie BDOT10k\.

```csharp
public interface IObiektGeometryczny : DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject
```

Derived  
↳ [PowierzchniowyObiektGeometryczny&lt;T&gt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>')  
↳ [IObiektGeometryczny&lt;T,X&gt;](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_ 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>')

Implements [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject')
### Methods

<a name='DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny.GetUnderlyingType()'></a>

## IObiektGeometryczny\.GetUnderlyingType\(\) Method

Pobiera typ bazowy obiektu geometrycznego\.

```csharp
System.Type? GetUnderlyingType();
```

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
Typ obiektu geometrycznego lub [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), jeśli nie jest określony\.

<a name='DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_'></a>

## IObiektGeometryczny\<T,X\> Interface

Definiuje generyczny interfejs dla obiektów geometrycznych z określonym typem geometrii oraz wyglądu\.

```csharp
public interface IObiektGeometryczny<T,X> : DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<T, X>, DiGi.Geometry.Visual.Core.Interfaces.IVisual<T, X>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<T>
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D
    where X : DiGi.Geometry.Visual.Core.Interfaces.IAppearance
```
#### Type parameters

<a name='DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.T'></a>

`T`

Typ geometrii 2D implementujący interfejs [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

<a name='DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.X'></a>

`X`

Typ wyglądu implementujący interfejs [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')\.

Derived  
↳ [PowierzchniowyObiektGeometryczny&lt;T&gt;](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.PowierzchniowyObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Geometry\.Classes\.PowierzchniowyObiektGeometryczny\<T\>')

Implements [IObiektGeometryczny](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d-2 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\`2')[T](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.T 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d-2 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\`2')[X](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.X 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.interfaces.ivisual2d-2 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\`2'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual-2 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\`2')[T](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.T 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual-2 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\`2')[X](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.X 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisual-2 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\`2'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.T 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[T](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny_T,X_.T 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')