#### [DiGi\.BDOT10k\.Geometry](index.md 'index')

## DiGi\.BDOT10k\.Geometry Namespace
### Classes

<a name='DiGi.BDOT10k.Geometry.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.BDOT10k.Geometry.Convert.ToDiGi(thisDiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny)'></a>

## Convert\.ToDiGi\(this IOT\_ObiektGeometryczny\) Method

Konwertuje obiekt geometryczny z formatu transferowego \(IOT\) na wewnętrzny format DiGi\.

```csharp
public static DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny? ToDiGi(this DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny? oT_ObiektGeometryczny);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Convert.ToDiGi(thisDiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny).oT_ObiektGeometryczny'></a>

`oT_ObiektGeometryczny` [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny](https://learn.microsoft.com/en-us/dotnet/api/digi.bdot10k.interfaces.iot_obiektgeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny')

Obiekt geometryczny w formacie transferowym do konwersji\.

#### Returns
[IObiektGeometryczny](DiGi.BDOT10k.Geometry.Interfaces.md#DiGi.BDOT10k.Geometry.Interfaces.IObiektGeometryczny 'DiGi\.BDOT10k\.Geometry\.Interfaces\.IObiektGeometryczny')  
Odpowiednik obiektu w formacie DiGi lub [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), jeśli wejściowy obiekt jest nullem\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Rzucane, gdy typ przekazanego obiektu nie jest obsługiwany przez konwerter\.

<a name='DiGi.BDOT10k.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.LinearRing)'></a>

## Convert\.ToDiGi\(this LinearRing\) Method

Konwertuje obiekt pierścienia liniowego GML na obiekt Polygon2D\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? ToDiGi(this DiGi.GML.Classes.LinearRing? linearRing);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.LinearRing).linearRing'></a>

`linearRing` [DiGi\.GML\.Classes\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.linearring 'DiGi\.GML\.Classes\.LinearRing')

Obiekt pierścienia liniowego GML do konwersji\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
Obiekt [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') reprezentujący dany pierścień liniowy, lub `null`, jeśli wejście jest nieprawidłowe, puste lub zawiera nieparzystą liczbę współrzędnych\.

<a name='DiGi.BDOT10k.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.Surface)'></a>

## Convert\.ToDiGi\(this Surface\) Method

Konwertuje obiekt powierzchni \(Surface\) z modelu GML na reprezentację PolygonalFace2D w bibliotece DiGi\.Geometry\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? ToDiGi(this DiGi.GML.Classes.Surface? surface);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.Surface).surface'></a>

`surface` [DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

Powierzchnia źródłowa do konwersji\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
Obiekt PolygonalFace2D będący wynikiem konwersji lub null, jeśli powierzchnia źródłowa jest nullem lub nie może zostać przekonwertowana\.

<a name='DiGi.BDOT10k.Geometry.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,DiGi.GML.Classes.FeatureCollection)'></a>

## Modify\.Load\(this SlownikObiektowGeometrycznych, FeatureCollection\) Method

Wczytuje obiekty geometryczne z kolekcji cech do słownika obiektów geometrycznych\.

```csharp
public static bool Load(this DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych slownikObiektowGeometrycznych, DiGi.GML.Classes.FeatureCollection featureCollection);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,DiGi.GML.Classes.FeatureCollection).slownikObiektowGeometrycznych'></a>

`slownikObiektowGeometrycznych` [SlownikObiektowGeometrycznych](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych')

Słownik, do którego zostaną dodane wczytane obiekty\.

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,DiGi.GML.Classes.FeatureCollection).featureCollection'></a>

`featureCollection` [DiGi\.GML\.Classes\.FeatureCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.featurecollection 'DiGi\.GML\.Classes\.FeatureCollection')

Kolekcja cech zawierająca elementy geometryczne\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Wartość [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') wskazująca, czy udało się pomyślnie dodać co najmniej jeden obiekt do słownika\.

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,string)'></a>

## Modify\.Load\(this SlownikObiektowGeometrycznych, string\) Method

Wczytuje obiekty geometryczne z pliku o podanej ścieżce do słownika obiektów geometrycznych\.

```csharp
public static bool Load(this DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych? slownikObiektowGeometrycznych, string? path);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,string).slownikObiektowGeometrycznych'></a>

`slownikObiektowGeometrycznych` [SlownikObiektowGeometrycznych](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych')

Słownik, do którego zostaną dodane wczytane obiekty\.

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Ścieżka do pliku zawierającego dane w formacie GML\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Wartość [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') wskazująca, czy udało się pomyślnie wczytać i dodać co najmniej jeden obiekt do słownika\.

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,System.IO.Stream)'></a>

## Modify\.Load\(this SlownikObiektowGeometrycznych, Stream\) Method

Wczytuje obiekty geometryczne ze strumienia danych do słownika obiektów geometrycznych\.

```csharp
public static bool Load(this DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych? slownikObiektowGeometrycznych, System.IO.Stream? stream);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,System.IO.Stream).slownikObiektowGeometrycznych'></a>

`slownikObiektowGeometrycznych` [SlownikObiektowGeometrycznych](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych 'DiGi\.BDOT10k\.Geometry\.Classes\.SlownikObiektowGeometrycznych')

Słownik, do którego zostaną dodane wczytane obiekty\.

<a name='DiGi.BDOT10k.Geometry.Modify.Load(thisDiGi.BDOT10k.Geometry.Classes.SlownikObiektowGeometrycznych,System.IO.Stream).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

Strumień wejściowy zawierający dane w formacie GML\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Wartość [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') wskazująca, czy udało się pomyślnie wczytać i dodać co najmniej jeden obiekt do słownika\.

<a name='DiGi.BDOT10k.Geometry.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.BDOT10k.Geometry.Query.ADMS_A(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.BUBD_A)'></a>

## Query\.ADMS\_A\(this IEnumerable\<ADMS\_A\>, BUBD\_A\) Method

Wyszukuje najbardziej dopasowany obiekt ADMS\_A dla podanego obiektu BUBD\_A na podstawie analizy przestrzennej, 
sprawdzając zawarcie punktu wewnętrznego, punktów krawędzi zewnętrznej lub najbliższą odległość\.

```csharp
public static DiGi.BDOT10k.Geometry.Classes.ADMS_A? ADMS_A(this System.Collections.Generic.IEnumerable<DiGi.BDOT10k.Geometry.Classes.ADMS_A>? aDMS_As, DiGi.BDOT10k.Geometry.Classes.BUBD_A? bUBD_A);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Query.ADMS_A(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.BUBD_A).aDMS_As'></a>

`aDMS_As` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ADMS\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.ADMS_A 'DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Kolekcja obiektów ADMS\_A do przeszukania\.

<a name='DiGi.BDOT10k.Geometry.Query.ADMS_A(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.BUBD_A).bUBD_A'></a>

`bUBD_A` [BUBD\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.BUBD_A 'DiGi\.BDOT10k\.Geometry\.Classes\.BUBD\_A')

Obiekt BUBD\_A służący jako punkt odniesienia dla wyszukiwania\.

#### Returns
[ADMS\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.ADMS_A 'DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A')  
Najbardziej dopasowany obiekt ADMS\_A lub `null`, jeśli nie znaleziono pasującego obiektu lub przekazano nieprawidłowe argumenty\.

<a name='DiGi.BDOT10k.Geometry.Query.LiczbaMieszkancow(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.ADMS_A)'></a>

## Query\.LiczbaMieszkancow\(this IEnumerable\<ADMS\_A\>, ADMS\_A\) Method

Oblicza liczbę mieszkańców dla określonego obiektu [ADMS\_A\(this IEnumerable&lt;ADMS\_A&gt;, BUBD\_A\)](DiGi.BDOT10k.Geometry.md#DiGi.BDOT10k.Geometry.Query.ADMS_A(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.BUBD_A) 'DiGi\.BDOT10k\.Geometry\.Query\.ADMS\_A\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A\>, DiGi\.BDOT10k\.Geometry\.Classes\.BUBD\_A\)') na podstawie dostarczonej kolekcji obiektów, 
uwzględniając relacje przestrzenne oraz hierarchię obszarów \(odejmowanie populacji mniejszych obszarów zawartych w większych\)\.

```csharp
public static System.Nullable<uint> LiczbaMieszkancow(this System.Collections.Generic.IEnumerable<DiGi.BDOT10k.Geometry.Classes.ADMS_A> aDMS_As, DiGi.BDOT10k.Geometry.Classes.ADMS_A aDMS_A);
```
#### Parameters

<a name='DiGi.BDOT10k.Geometry.Query.LiczbaMieszkancow(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.ADMS_A).aDMS_As'></a>

`aDMS_As` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ADMS\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.ADMS_A 'DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Kolekcja obiektów typu [ADMS\_A\(this IEnumerable&lt;ADMS\_A&gt;, BUBD\_A\)](DiGi.BDOT10k.Geometry.md#DiGi.BDOT10k.Geometry.Query.ADMS_A(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.BUBD_A) 'DiGi\.BDOT10k\.Geometry\.Query\.ADMS\_A\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A\>, DiGi\.BDOT10k\.Geometry\.Classes\.BUBD\_A\)') służąca do analizy przestrzennej i obliczeń\.

<a name='DiGi.BDOT10k.Geometry.Query.LiczbaMieszkancow(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.ADMS_A).aDMS_A'></a>

`aDMS_A` [ADMS\_A](DiGi.BDOT10k.Geometry.Classes.md#DiGi.BDOT10k.Geometry.Classes.ADMS_A 'DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A')

Obiekt typu [ADMS\_A\(this IEnumerable&lt;ADMS\_A&gt;, BUBD\_A\)](DiGi.BDOT10k.Geometry.md#DiGi.BDOT10k.Geometry.Query.ADMS_A(thisSystem.Collections.Generic.IEnumerable_DiGi.BDOT10k.Geometry.Classes.ADMS_A_,DiGi.BDOT10k.Geometry.Classes.BUBD_A) 'DiGi\.BDOT10k\.Geometry\.Query\.ADMS\_A\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.BDOT10k\.Geometry\.Classes\.ADMS\_A\>, DiGi\.BDOT10k\.Geometry\.Classes\.BUBD\_A\)'), dla którego wyznaczana jest liczba mieszkańców\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
Liczba mieszkańców jako wartość [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32') lub null, jeśli dane są niedostępne lub nie spełniają kryteriów\.