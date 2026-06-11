using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Reprezentuje szczegółowe funkcje budynków w klasyfikacji BDOT10k.
    /// </summary>
    public enum OT_FunSzczegolowaBudynku
    {
        /// <summary>Apteka</summary>
        [Description("apteka")] apteka,
        /// <summary>Archiwum</summary>
        [Description("archiwum")] archiwum,
        /// <summary>Areszt śledczy</summary>
        [Description("areszt śledczy")] areszt_sledczy,
        /// <summary>Bacówka</summary>
        [Description("bacówka")] bacowka,
        /// <summary>Bank</summary>
        [Description("bank")] bank,
        /// <summary>Basen kąpielowy</summary>
        [Description("basen kąpielowy")] basen_kapielowy,
        /// <summary>Biblioteka</summary>
        [Description("biblioteka")] biblioteka,
        /// <summary>Budynek gospodarczy</summary>
        [Description("budynek gospodarczy")] budynek_gospodarczy,
        /// <summary>Budynek jednorodzinny</summary>
        [Description("budynek jednorodzinny")] budynek_jednorodzinny,
        /// <summary>Budynek kontroli ruchu kolejowego</summary>
        [Description("budynek kontroli ruchu kolejowego")] budynek_kontroli_ruchu_kolejowego,
        /// <summary>Budynek kontroli ruchu powietrznego</summary>
        [Description("budynek kontroli ruchu powietrznego")] budynek_kontroli_ruchu_powietrznego,
        /// <summary>Budynek ogrodu zoologicznego lub botanicznego</summary>
        [Description("budynek ogrodu zoologicznego lub botanicznego")] budynek_ogrodu_zoologicznego_lub_botanicznego,
        /// <summary>Budynek produkcyjny zwierząt hodowlanych</summary>
        [Description("budynek produkcyjny zwierząt hodowlanych")] budynek_produkcyjny_zwierzat_hodowlanych,
        /// <summary>Budynek spedycji</summary>
        [Description("budynek spedycji")] budynek_spedycji,
        /// <summary>Budynek wielorodzinny</summary>
        [Description("budynek wielorodzinny")] budynek_wielorodzinny,
        /// <summary>Budynki cmentarne</summary>
        [Description("budynki cmentarne")] budynki_cmentarne,
        /// <summary>Centrum handlowe</summary>
        [Description("centrum handlowe")] centrum_handlowe,
        /// <summary>Centrum informacyjne</summary>
        [Description("centrum informacyjne")] centrum_informacyjne,
        /// <summary>Centrum konferencyjne</summary>
        [Description("centrum konferencyjne")] centrum_konferencyjne,
        /// <summary>Centrum telekomunikacyjne</summary>
        [Description("centrum telekomunikacyjne")] centrum_telekomunikacyjne,
        /// <summary>Cerkiew</summary>
        [Description("cerkiew")] cerkiew,
        /// <summary>Chłodnia</summary>
        [Description("chłodnia")] chlodnia,
        /// <summary>Dom dla bezdomnych</summary>
        [Description("dom dla bezdomnych")] dom_dla_bezdomnych,
        /// <summary>Dom dziecka</summary>
        [Description("dom dziecka")] dom_dziecka,
        /// <summary>Dom kultury</summary>
        [Description("dom kultury")] dom_kultury,
        /// <summary>Dom letniskowy</summary>
        [Description("dom letniskowy")] dom_letniskowy,
        /// <summary>Dom opieki społecznej</summary>
        [Description("dom opieki społecznej")] dom_opieki_spolecznej,
        /// <summary>Dom parafialny</summary>
        [Description("dom parafialny")] dom_parafialny,
        /// <summary>Dom pogrzebowy</summary>
        [Description("dom pogrzebowy")] dom_pogrzebowy,
        /// <summary>Dom rekolekcyjny</summary>
        [Description("dom rekolekcyjny")] dom_rekolekcyjny,

        /// <summary>Dom studencki</summary>
        [Description("dom studencki")] dom_studencki,
        /// <summary>Dom towarowy lub handlowy</summary>
        [Description("dom towarowy lub handlowy")] dom_towarowy_lub_handlowy,
        /// <summary>Dom weselny</summary>
        [Description("dom weselny")] dom_weselny,
        /// <summary>Dom wypoczynkowy</summary>
        [Description("dom wypoczynkowy")] dom_wypoczynkowy,
        /// <summary>Dom zakonny</summary>
        [Description("dom zakonny")] dom_zakonny,
        /// <summary>Domek kempingowy</summary>
        [Description("domek kempingowy")] domek_kempingowy,
        /// <summary>Dworzec autobusowy</summary>
        [Description("dworzec autobusowy")] dworzec_autobusowy,
        /// <summary>Dworzec kolejowy</summary>
        [Description("dworzec kolejowy")] dworzec_kolejowy,
        /// <summary>Dworzec lotniczy</summary>
        [Description("dworzec lotniczy")] dworzec_lotniczy,
        /// <summary>Dzwonnica</summary>
        [Description("dzwonnica")] dzwonnica,
        /// <summary>Elektrociepłownia</summary>
        [Description("elektrociepłownia")] elektrocieplownia,
        /// <summary>Elektrownia</summary>
        [Description("elektrownia")] elektrownia,
        /// <summary>Elewator</summary>
        [Description("elewator")] elewator,
        /// <summary>Filharmonia</summary>
        [Description("filharmonia")] filharmonia,
        /// <summary>Galeria sztuki</summary>
        [Description("galeria sztuki")] galeria_sztuki,
        /// <summary>Garaż</summary>
        [Description("garaż")] garaz,
        /// <summary>Hala sportowa</summary>
        [Description("hala sportowa")] hala_sportowa,
        /// <summary>Hala targowa</summary>
        [Description("hala targowa")] hala_targowa,
        /// <summary>Hala widowiskowa</summary>
        [Description("hala widowiskowa")] hala_widowiskowa,
        /// <summary>Hala wystawowa</summary>
        [Description("hala wystawowa")] hala_wystawowa,
        /// <summary>Halowy tor gokartowy</summary>
        [Description("halowy tor gokartowy")] halowy_tor_gokartowy,
        /// <summary>Hangar</summary>
        [Description("hangar")] hangar,
        /// <summary>Hipermarket lub supermarket</summary>
        [Description("hipermarket lub supermarket")] hipermarket_lub_supermarket,
        /// <summary>Hospicjum</summary>
        [Description("hospicjum")] hospicjum,
        /// <summary>Hotel</summary>
        [Description("hotel")] hotel,
        /// <summary>Hotel robotniczy</summary>
        [Description("hotel robotniczy")] hotel_robotniczy,
        /// <summary>Inna placówka edukacyjna</summary>
        [Description("inna placówka edukacyjna")] inna_placowka_edukacyjna,
        /// <summary>Inny budynek kultu religijnego</summary>
        [Description("inny budynek kultu religijnego")] inny_budynek_kultu_religijnego,
        /// <summary>Inny urząd administracji publicznej</summary>
        [Description("inny urząd administracji publicznej")] inny_urzad_administracji_publicznej,
        /// <summary>Internat lub bursa szkolna</summary>
        [Description("internat lub bursa szkolna")] internat_lub_bursa_szkolna,

        /// <summary>Izba wytrzeźwień</summary>
        [Description("izba wytrzeźwień")] izba_wytrzezwien,
        /// <summary>Jednostka ratownictwa medycznego</summary>
        [Description("jednostka ratownictwa medycznego")] jednostka_ratownictwa_medycznego,
        /// <summary>Kapitanat lub bosmanat portu</summary>
        [Description("kapitanat lub bosmanat portu")] kapitanat_lub_bosmanat_portu,
        /// <summary>Kaplica</summary>
        [Description("kaplica")] kaplica,
        /// <summary>Kasyno</summary>
        [Description("kasyno")] kasyno,
        /// <summary>Kino</summary>
        [Description("kino")] kino,
        /// <summary>Klasztor</summary>
        [Description("klasztor")] klasztor,
        /// <summary>Klinika weterynaryjna</summary>
        [Description("klinika weterynaryjna")] klinika_weterynaryjna,
        /// <summary>Klub sportowy</summary>
        [Description("klub sportowy")] klub_sportowy,
        /// <summary>Klub, dyskoteka</summary>
        [Description("klub, dyskoteka")] klub_dyskoteka,
        /// <summary>Korty tenisowe</summary>
        [Description("korty tenisowe")] korty_tenisowe,
        /// <summary>Koszary</summary>
        [Description("koszary")] koszary,
        /// <summary>Kościół</summary>
        [Description("kościół")] kosciol,
        /// <summary>Kotłownia</summary>
        [Description("kotłownia")] kotlownia,
        /// <summary>Krematorium</summary>
        [Description("krematorium")] krematorium,
        /// <summary>Kręgielnia</summary>
        [Description("kręgielnia")] kregielnia,
        /// <summary>Kuria metropolitalna</summary>
        [Description("kuria metropolitalna")] kuria_metropolitalna,
        /// <summary>Latarnia morska</summary>
        [Description("latarnia morska")] latarnia_morska,
        /// <summary>Leśniczówka</summary>
        [Description("leśniczówka")] lesniczowka,
        /// <summary>Lokomotywownia lub wagonownia</summary>
        [Description("lokomotywownia lub wagonownia")] lokomotywownia_lub_wagonownia,
        /// <summary>Magazyn</summary>
        [Description("magazyn")] magazyn,
        /// <summary>Meczet</summary>
        [Description("meczet")] meczet,
        /// <summary>Ministerstwo</summary>
        [Description("ministerstwo")] ministerstwo,
        /// <summary>Młyn</summary>
        [Description("młyn")] mlyn,
        /// <summary>Motel</summary>
        [Description("motel")] motel,
        /// <summary>Muzeum</summary>
        [Description("muzeum")] muzeum,
        /// <summary>Myjnia samochodowa</summary>
        [Description("myjnia samochodowa")] myjnia_samochodowa,
        /// <summary>Obserwatorium lub planetarium</summary>
        [Description("obserwatorium lub planetarium")] obserwatorium_lub_planetarium,
        /// <summary>Opera</summary>
        [Description("opera")] opera,
        /// <summary>Ośrodek pomocy społecznej</summary>
        [Description("ośrodek pomocy społecznej")] osrodek_pomocy_spolecznej,

        /// <summary>Ośrodek szkoleniowo-wypoczynkowy</summary>
        [Description("ośrodek szkoleniowo-wypoczynkowy")] osrodek_szkoleniowo_wypoczynkowy,
        /// <summary>Parking wielopoziomowy</summary>
        [Description("parking wielopoziomowy")] parking_wielopoziomowy,
        /// <summary>Obiekt handlowo-usługowy</summary>
        [Description("obiekt handlowo-usługowy")] obiekt_handlowo_uslugowy,
        /// <summary>Pawilon ogrodowy lub oranżeria</summary>
        [Description("pawilon ogrodowy lub oranżeria")] pawilon_ogrodowy_lub_oranzeria,
        /// <summary>Pensjonat</summary>
        [Description("pensjonat")] pensjonat,
        /// <summary>Placówka badawcza</summary>
        [Description("placówka badawcza")] placowka_badawcza,
        /// <summary>Placówka dyplomatyczna lub konsularna</summary>
        [Description("placówka dyplomatyczna lub konsularna")] placowka_dyplomatyczna_lub_konsularna,
        /// <summary>Placówka ochrony zdrowia</summary>
        [Description("placówka ochrony zdrowia")] placowka_ochrony_zdrowia,
        /// <summary>Placówka operatora pocztowego</summary>
        [Description("placówka operatora pocztowego")] placowka_operatora_pocztowego,
        /// <summary>Placówka opiekuńczo-wychowawcza</summary>
        [Description("placówka opiekuńczo-wychowawcza")] placowka_opiekunczo_wychowawcza,
        /// <summary>Policja</summary>
        [Description("policja")] policja,
        /// <summary>Produkcyjny</summary>
        [Description("produkcyjny")] produkcyjny,
        /// <summary>Prokuratura</summary>
        [Description("prokuratura")] prokuratura,
        /// <summary>Przedszkole</summary>
        [Description("przedszkole")] przedszkole,
        /// <summary>Przejście graniczne</summary>
        [Description("przejście graniczne")] przejscie_graniczne,
        /// <summary>Rafineria</summary>
        [Description("rafineria")] rafineria,
        /// <summary>Restauracja</summary>
        [Description("restauracja")] restauracja,
        /// <summary>Rezydencja ambasadora</summary>
        [Description("rezydencja ambasadora")] rezydencja_ambasadora,
        /// <summary>Rezydencja biskupia</summary>
        [Description("rezydencja biskupia")] rezydencja_biskupia,
        /// <summary>Rezydencja prezydencka</summary>
        [Description("rezydencja prezydencka")] rezydencja_prezydencka,
        /// <summary>Sala gimnastyczna</summary>
        [Description("sala gimnastyczna")] sala_gimnastyczna,
        /// <summary>Sanatorium</summary>
        [Description("sanatorium")] sanatorium,
        /// <summary>Sąd</summary>
        [Description("sąd")] sad,
        /// <summary>Schronisko dla nieletnich</summary>
        [Description("schronisko dla nieletnich")] schronisko_dla_nieletnich,
        /// <summary>Schronisko dla zwierząt</summary>
        [Description("schronisko dla zwierząt")] schronisko_dla_zwierzat,
        /// <summary>Schronisko turystyczne</summary>
        [Description("schronisko turystyczne")] schronisko_turystyczne,
        /// <summary>Siedziba firmy lub firm</summary>
        [Description("siedziba firmy lub firm")] siedziba_firmy_lub_firm,
        /// <summary>Silos</summary>
        [Description("silos")] silos,
        /// <summary>Spalarnia śmieci</summary>
        [Description("spalarnia śmieci")] spalarnia_smieci,
        /// <summary>Stacja gazowa</summary>
        [Description("stacja gazowa")] stacja_gazowa,

        /// <summary>Stacja hydrologiczna</summary>
        [Description("stacja hydrologiczna")] stacja_hydrologiczna,
        /// <summary>Stacja kolejki górskiej lub wyciągu krzesełkowego</summary>
        [Description("stacja kolejki górskiej lub wyciągu krzesełkowego")] stacja_kolejki_gorskiej_lub_wyciagu_krzeselkowego,
        /// <summary>Stacja krwiodawstwa</summary>
        [Description("stacja krwiodawstwa")] stacja_krwiodawstwa,
        /// <summary>Stacja meteorologiczna</summary>
        [Description("stacja meteorologiczna")] stacja_meteorologiczna,
        /// <summary>Stacja nadawcza radia i telewizji</summary>
        [Description("stacja nadawcza radia i telewizji")] stacja_nadawcza_radia_i_telewizji,
        /// <summary>Stacja nautyczna</summary>
        [Description("stacja nautyczna")] stacja_nautyczna,
        /// <summary>Stacja obsługi pojazdów</summary>
        [Description("stacja obsługi pojazdów")] stacja_obslugi_pojazdow,
        /// <summary>Stacja paliw</summary>
        [Description("stacja paliw")] stacja_paliw,
        /// <summary>Stacja pomp</summary>
        [Description("stacja pomp")] stacja_pomp,
        /// <summary>Stacja sanitarno-epidemiologiczna</summary>
        [Description("stacja sanitarno-epidemiologiczna")] stacja_sanitarno_epidemiologiczna,
        /// <summary>Stacja transformatorowa</summary>
        [Description("stacja transformatorowa")] stacja_transformatorowa,
        /// <summary>Stajnia</summary>
        [Description("stajnia")] stajnia,
        /// <summary>Starostwo powiatowe</summary>
        [Description("starostwo powiatowe")] starostwo_powiatowe,
        /// <summary>Straż graniczna</summary>
        [Description("straż graniczna")] straz_graniczna,
        /// <summary>Straż pożarna</summary>
        [Description("straż pożarna")] straz_pozarna,
        /// <summary>Strzelnica</summary>
        [Description("strzelnica")] strzelnica,
        /// <summary>Synagoga</summary>
        [Description("synagoga")] synagoga,
        /// <summary>Szklarnia lub cieplarnia</summary>
        [Description("szklarnia lub cieplarnia")] szklarnia_lub_cieplarnia,
        /// <summary>Szkoła podstawowa</summary>
        [Description("szkoła podstawowa")] szkola_podstawowa,
        /// <summary>Szkoła ponadpodstawowa</summary>
        [Description("szkoła ponadpodstawowa")] szkola_ponadpodstawowa,
        /// <summary>Szkoła wyższa</summary>
        [Description("szkoła wyższa")] szkoła_wyzsza,
        /// <summary>Szpital</summary>
        [Description("szpital")] szpital,
        /// <summary>Sztuczne lodowisko</summary>
        [Description("sztuczne lodowisko")] sztuczne_lodowisko,
        /// <summary>Teatr</summary>
        [Description("teatr")] teatr,
        /// <summary>Terminal portowy</summary>
        [Description("terminal portowy")] terminal_portowy,
        /// <summary>Toaleta publiczna</summary>
        [Description("toaleta publiczna")] toaleta_publiczna,
        /// <summary>Ujeżdżalnia</summary>
        [Description("ujeżdżalnia")] ujezdzalnia,
        /// <summary>Urząd celny</summary>
        [Description("urząd celny")] urzad_celny,
        /// <summary>Urząd gminy</summary>
        [Description("urząd gminy")] urzad_gminy,
        /// <summary>Urząd marszałkowski</summary>
        [Description("urząd marszałkowski")] urzad_marszalkowski,

        /// <summary>Urząd miasta</summary>
        [Description("urząd miasta")] urzad_miasta,
        /// <summary>Urząd miasta i gminy</summary>
        [Description("urząd miasta i gminy")] urzad_miasta_i_gminy,
        /// <summary>Urząd wojewódzki</summary>
        [Description("urząd wojewódzki")] urzad_wojewodzki,
        /// <summary>Warsztat remontowo-naprawczy</summary>
        [Description("warsztat remontowo-naprawczy")] warsztat_remontowo_naprawczy,
        /// <summary>Wiatrak</summary>
        [Description("wiatrak")] wiatrak,
        /// <summary>Zabudowania koszarowe</summary>
        [Description("zabudowania koszarowe")] zabudowania_koszarowe,
        /// <summary>Zabytek niepełniący żadnej funkcji użytkowej</summary>
        [Description("zabytek niepełniący żadnej funkcji użytkowej")] zabytek_niepelniacy_zadnej_funkcji_uzytkowej,
        /// <summary>Zajazd</summary>
        [Description("zajazd")] zajazd,
        /// <summary>Zajezdnia autobusowa</summary>
        [Description("zajezdnia autobusowa")] zajezdnia_autobusowa,
        /// <summary>Zajezdnia tramwajowa</summary>
        [Description("zajezdnia tramwajowa")] zajezdnia_tramwajowa,
        /// <summary>Zajezdnia trolejbusowa</summary>
        [Description("zajezdnia trolejbusowa")] zajezdnia_trolejbusowa,
        /// <summary>Zakład karny</summary>
        [Description("zakład karny")] zaklad_karny,
        /// <summary>Zakład karny lub poprawczy</summary>
        [Description("zakład karny lub poprawczy")] zaklad_karny_lub_poprawczy,
        /// <summary>Zakład poprawczy</summary>
        [Description("zakład poprawczy")] zaklad_poprawczy,
        /// <summary>Zbiornik na ciecz</summary>
        [Description("zbiornik na ciecz")] zbiornik_na_ciecz,
        /// <summary>Zbiornik na gaz</summary>
        [Description("zbiornik na gaz")] zbiornik_na_gaz,
        /// <summary>Żłobek</summary>
        [Description("żłobek")] zlobek,
    }
}