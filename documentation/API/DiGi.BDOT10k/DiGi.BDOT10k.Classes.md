#### [DiGi\.BDOT10k](index.md 'index')

## DiGi\.BDOT10k\.Classes Namespace
### Classes

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A'></a>

## OT\_ADJA\_A Class

Reprezentuje obiekt jednostki administracyjnej w ramach podziału terytorialnego \(BDOT10k\)\.

```csharp
public class OT_ADJA_A : DiGi.BDOT10k.Classes.OT_PodzialTerytorialny, DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny') → OT\_ADJA\_A

Implements [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.OT_ADJA_A()'></a>

## OT\_ADJA\_A\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')\.

```csharp
public OT_ADJA_A();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.geometria'></a>

## OT\_ADJA\_A\.geometria Property

Geometria powierzchniowa obiektu\.

```csharp
public DiGi.GML.Classes.Surface geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.identyfikatorPRG'></a>

## OT\_ADJA\_A\.identyfikatorPRG Property

Identyfikator PRG jednostki administracyjnej\.

```csharp
public string identyfikatorPRG { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.identyfikatorTERYTjednostki'></a>

## OT\_ADJA\_A\.identyfikatorTERYTjednostki Property

Identyfikator TERYT jednostki administracyjnej\.

```csharp
public string identyfikatorTERYTjednostki { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.idTERYTjednostkiNadrzednej'></a>

## OT\_ADJA\_A\.idTERYTjednostkiNadrzednej Property

Identyfikator TERYT jednostki nadrzędnej\.

```csharp
public string? idTERYTjednostkiNadrzednej { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.rodzaj'></a>

## OT\_ADJA\_A\.rodzaj Property

Rodzaj jednostki administracyjnej\.

```csharp
public DiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej rodzaj { get; set; }
```

#### Property Value
[OT\_RodzajJednostkiAdministracyjnej](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej 'DiGi\.BDOT10k\.Enums\.OT\_RodzajJednostkiAdministracyjnej')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A'></a>

## OT\_ADMS\_A Class

Reprezentuje obiekt administracyjny typu A w ramach podziału terytorialnego BDOT10k\.

```csharp
public class OT_ADMS_A : DiGi.BDOT10k.Classes.OT_PodzialTerytorialny, DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny') → OT\_ADMS\_A

Implements [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.OT_ADMS_A()'></a>

## OT\_ADMS\_A\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')\.

```csharp
public OT_ADMS_A();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.geometria'></a>

## OT\_ADMS\_A\.geometria Property

Geometria powierzchniowa obiektu\.

```csharp
public DiGi.GML.Classes.Surface geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.identyfikatorPRNG'></a>

## OT\_ADMS\_A\.identyfikatorPRNG Property

Identyfikator PRNG\.

```csharp
public string identyfikatorPRNG { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.identyfikatorSIMC'></a>

## OT\_ADMS\_A\.identyfikatorSIMC Property

Identyfikator SIMC \(System Identyfikacji Miejscowości i Członów\)\.

```csharp
public string? identyfikatorSIMC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.identyfikatorTERC'></a>

## OT\_ADMS\_A\.identyfikatorTERC Property

Identyfikator TERC\.

```csharp
public string identyfikatorTERC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.liczbaMieszkancow'></a>

## OT\_ADMS\_A\.liczbaMieszkancow Property

Liczba mieszkańców\.

```csharp
public System.Nullable<uint> liczbaMieszkancow { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.rodzaj'></a>

## OT\_ADMS\_A\.rodzaj Property

Rodzaj miejscowości\.

```csharp
public DiGi.BDOT10k.Enums.OT_RodzajMiejscowosci rodzaj { get; set; }
```

#### Property Value
[OT\_RodzajMiejscowosci](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_RodzajMiejscowosci 'DiGi\.BDOT10k\.Enums\.OT\_RodzajMiejscowosci')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A'></a>

## OT\_BUBD\_A Class

Reprezentuje obiekt budynku w standardzie BDOT10k\.

```csharp
public class OT_BUBD_A : DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia, DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_BudynkiBudowleIUrzadzenia](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia 'DiGi\.BDOT10k\.Classes\.OT\_BudynkiBudowleIUrzadzenia') → OT\_BUBD\_A

Implements [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.OT_BUBD_A()'></a>

## OT\_BUBD\_A\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')\.

```csharp
public OT_BUBD_A();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.funkcjaOgolnaBudynku'></a>

## OT\_BUBD\_A\.funkcjaOgolnaBudynku Property

Ogólna funkcja budynku\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_FunOgolnaBudynku> funkcjaOgolnaBudynku { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_FunOgolnaBudynku](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_FunOgolnaBudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunOgolnaBudynku')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.funkcjaSzczegolowaBudynku'></a>

## OT\_BUBD\_A\.funkcjaSzczegolowaBudynku Property

Lista szczegółowych funkcji budynku\.

```csharp
public System.Collections.Generic.List<DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku>? funkcjaSzczegolowaBudynku { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[OT\_FunSzczegolowaBudynku](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.geometria'></a>

## OT\_BUBD\_A\.geometria Property

Geometria powierzchniowa obiektu\.

```csharp
public DiGi.GML.Classes.Surface geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.identyfikatorEGiB'></a>

## OT\_BUBD\_A\.identyfikatorEGiB Property

Lista identyfikatorów z Ewidencji Gruntów i Budynków \(EGiB\)\.

```csharp
public System.Collections.Generic.List<string>? identyfikatorEGiB { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.kodKst'></a>

## OT\_BUBD\_A\.kodKst Property

Kod klasyfikacji obiektów budowlanych \(KST\)\.

```csharp
public string? kodKst { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.liczbaKondygnacji'></a>

## OT\_BUBD\_A\.liczbaKondygnacji Property

Liczba kondygnacji w budynku\.

```csharp
public System.Nullable<ushort> liczbaKondygnacji { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.nazwa'></a>

## OT\_BUBD\_A\.nazwa Property

Nazwa budynku\.

```csharp
public string? nazwa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.przewazajacaFunkcjaBudynku'></a>

## OT\_BUBD\_A\.przewazajacaFunkcjaBudynku Property

Przeważająca funkcja budynku\.

```csharp
public DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku przewazajacaFunkcjaBudynku { get; set; }
```

#### Property Value
[OT\_FunSzczegolowaBudynku](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku')

<a name='DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia'></a>

## OT\_BudynkiBudowleIUrzadzenia Class

Klasa bazowa dla obiektów topograficznych będących budynkami, budowlami i urządzeniami w standardzie BDOT10k\.

```csharp
public abstract class OT_BudynkiBudowleIUrzadzenia : DiGi.BDOT10k.Classes.OT_ObiektTopograficzny
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → OT\_BudynkiBudowleIUrzadzenia

Derived  
↳ [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia.OT_BudynkiBudowleIUrzadzenia()'></a>

## OT\_BudynkiBudowleIUrzadzenia\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_BudynkiBudowleIUrzadzenia](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia 'DiGi\.BDOT10k\.Classes\.OT\_BudynkiBudowleIUrzadzenia')\.

```csharp
public OT_BudynkiBudowleIUrzadzenia();
```

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny'></a>

## OT\_ObiektTopograficzny Class

Reprezentuje bazową klasę dla obiektów topograficznych w standardzie BDOT10k\.

```csharp
public abstract class OT_ObiektTopograficzny : DiGi.GML.Classes.GML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → OT\_ObiektTopograficzny

Derived  
↳ [OT\_BudynkiBudowleIUrzadzenia](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia 'DiGi\.BDOT10k\.Classes\.OT\_BudynkiBudowleIUrzadzenia')  
↳ [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.OT_ObiektTopograficzny()'></a>

## OT\_ObiektTopograficzny\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny')\.

```csharp
public OT_ObiektTopograficzny();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.informacjaDodatkowa'></a>

## OT\_ObiektTopograficzny\.informacjaDodatkowa Property

Pobiera lub ustawia dodatkowe informacje o obiekcie\.

```csharp
public string? informacjaDodatkowa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.kategoriaIstnienia'></a>

## OT\_ObiektTopograficzny\.kategoriaIstnienia Property

Pobiera lub ustawia kategorię istnienia obiektu topograficznego\.

```csharp
public DiGi.BDOT10k.Enums.OT_KatIstnienia kategoriaIstnienia { get; set; }
```

#### Property Value
[OT\_KatIstnienia](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_KatIstnienia 'DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.kodKarto10k'></a>

## OT\_ObiektTopograficzny\.kodKarto10k Property

Pobiera lub ustawia kod kartograficzny dla mapy w skali 1:10 000\.

```csharp
public string? kodKarto10k { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.kodKarto250k'></a>

## OT\_ObiektTopograficzny\.kodKarto250k Property

Pobiera lub ustawia kod kartograficzny dla mapy w skali 1:250 000\.

```csharp
public string? kodKarto250k { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.koniecWersjiObiektu'></a>

## OT\_ObiektTopograficzny\.koniecWersjiObiektu Property

Pobiera lub ustawia datę zakończenia obowiązywania wersji obiektu\.

```csharp
public System.Nullable<System.DateTime> koniecWersjiObiektu { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.lokalnyId'></a>

## OT\_ObiektTopograficzny\.lokalnyId Property

Pobiera lub ustawia lokalny identyfikator obiektu\.

```csharp
public string lokalnyId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.oznaczenieZmiany'></a>

## OT\_ObiektTopograficzny\.oznaczenieZmiany Property

Pobiera lub ustawia oznaczenie wprowadzonej zmiany w obiekcie\.

```csharp
public string oznaczenieZmiany { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.poczatekWersjiObiektu'></a>

## OT\_ObiektTopograficzny\.poczatekWersjiObiektu Property

Pobiera lub ustawia datę rozpoczęcia obowiązywania wersji obiektu\.

```csharp
public System.DateTime poczatekWersjiObiektu { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.przestrzenNazw'></a>

## OT\_ObiektTopograficzny\.przestrzenNazw Property

Pobiera lub ustawia przestrzeń nazw, do której należy obiekt\.

```csharp
public string przestrzenNazw { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.skrotKartograficzny'></a>

## OT\_ObiektTopograficzny\.skrotKartograficzny Property

Pobiera lub ustawia skrót kartograficzny obiektu\.

```csharp
public string? skrotKartograficzny { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.uwagi'></a>

## OT\_ObiektTopograficzny\.uwagi Property

Pobiera lub ustawia uwagi dotyczące obiektu\.

```csharp
public string? uwagi { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.wersja'></a>

## OT\_ObiektTopograficzny\.wersja Property

Pobiera lub ustawia datę i godzinę wersji obiektu\.

```csharp
public System.DateTime wersja { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.zrodloDanychGeometrycznych'></a>

## OT\_ObiektTopograficzny\.zrodloDanychGeometrycznych Property

Pobiera lub ustawia źródło danych geometrycznych obiektu\.

```csharp
public DiGi.BDOT10k.Enums.OT_ZrodloDanych zrodloDanychGeometrycznych { get; set; }
```

#### Property Value
[OT\_ZrodloDanych](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_ZrodloDanych 'DiGi\.BDOT10k\.Enums\.OT\_ZrodloDanych')

<a name='DiGi.BDOT10k.Classes.OT_PodzialTerytorialny'></a>

## OT\_PodzialTerytorialny Class

Reprezentuje abstrakcyjną klasę dla obiektów topograficznych należących do podziału terytorialnego\.

```csharp
public abstract class OT_PodzialTerytorialny : DiGi.BDOT10k.Classes.OT_ObiektTopograficzny
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → OT\_PodzialTerytorialny

Derived  
↳ [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')  
↳ [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_PodzialTerytorialny.OT_PodzialTerytorialny()'></a>

## OT\_PodzialTerytorialny\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny')\.

```csharp
public OT_PodzialTerytorialny();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_PodzialTerytorialny.nazwa'></a>

## OT\_PodzialTerytorialny\.nazwa Property

Pobiera lub ustawia nazwę jednostki podziału terytorialnego\.

```csharp
public string nazwa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')