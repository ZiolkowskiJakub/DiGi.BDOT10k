#### [DiGi\.BDOT10k](index.md 'index')

## DiGi\.BDOT10k\.Interfaces Namespace
### Interfaces

<a name='DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny'></a>

## IOT\_LiniowyObiektGeometryczny Interface

Interfejs definiujący liniowy obiekt geometryczny w ramach modelu danych BDOT10k\.

```csharp
public interface IOT_LiniowyObiektGeometryczny : DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Implements [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')

<a name='DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny'></a>

## IOT\_ObiektGeometryczny Interface

Interfejs definiujący podstawowe właściwości obiektu geometrycznego w standardzie BDOT10k\.

```csharp
public interface IOT_ObiektGeometryczny : DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Derived  
↳ [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')  
↳ [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')  
↳ [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')  
↳ [IOT\_LiniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_LiniowyObiektGeometryczny')  
↳ [IOT\_ObiektGeometryczny&lt;T&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')  
↳ [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny')

Implements [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')

<a name='DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_'></a>

## IOT\_ObiektGeometryczny\<T\> Interface

Generyczny interfejs definiujący obiekt geometryczny z określonym typem geometrii\.

```csharp
public interface IOT_ObiektGeometryczny<T> : DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
    where T : DiGi.GML.Classes.GeometricPrimitive
```
#### Type parameters

<a name='DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.T'></a>

`T`

Typ prymitywu geometrycznego implementującego klasę GeometricPrimitive\.

Derived  
↳ [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')  
↳ [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')  
↳ [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')  
↳ [IOT\_LiniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_LiniowyObiektGeometryczny')  
↳ [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny')

Implements [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Properties

<a name='DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria'></a>

## IOT\_ObiektGeometryczny\<T\>\.geometria Property

Pobiera lub ustawia geometrię obiektu\.

```csharp
T geometria { get; set; }
```

#### Property Value
[T](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.T 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.T')

<a name='DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny'></a>

## IOT\_PowierzchniowyObiektGeometryczny Interface

Interfejs definiujący obiekt geometryczny o charakterze powierzchniowym w ramach modelu danych BDOT10k\.

```csharp
public interface IOT_PowierzchniowyObiektGeometryczny : DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Derived  
↳ [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')  
↳ [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')  
↳ [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')

Implements [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')