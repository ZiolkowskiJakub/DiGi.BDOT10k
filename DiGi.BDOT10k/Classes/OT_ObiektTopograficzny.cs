using DiGi.BDOT10k.Enums;
using System;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Reprezentuje bazową klasę dla obiektów topograficznych w standardzie BDOT10k.
    /// </summary>
    public abstract class OT_ObiektTopograficzny : GML.Classes.GML
    {
        /// <summary>
        /// Pobiera lub ustawia lokalny identyfikator obiektu.
        /// </summary>
        public string lokalnyId { get; set; } = string.Empty;

        /// <summary>
        /// Pobiera lub ustawia przestrzeń nazw, do której należy obiekt.
        /// </summary>
        public string przestrzenNazw { get; set; } = string.Empty;

        /// <summary>
        /// Pobiera lub ustawia datę i godzinę wersji obiektu.
        /// </summary>
        public DateTime wersja { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Pobiera lub ustawia datę rozpoczęcia obowiązywania wersji obiektu.
        /// </summary>
        public DateTime poczatekWersjiObiektu { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Pobiera lub ustawia datę zakończenia obowiązywania wersji obiektu.
        /// </summary>
        public DateTime? koniecWersjiObiektu { get; set; } = null;

        /// <summary>
        /// Pobiera lub ustawia oznaczenie wprowadzonej zmiany w obiekcie.
        /// </summary>
        public string oznaczenieZmiany { get; set; } = string.Empty;

        /// <summary>
        /// Pobiera lub ustawia źródło danych geometrycznych obiektu.
        /// </summary>
        public OT_ZrodloDanych zrodloDanychGeometrycznych { get; set; } = OT_ZrodloDanych.inne;

        /// <summary>
        /// Pobiera lub ustawia kategorię istnienia obiektu topograficznego.
        /// </summary>
        public OT_KatIstnienia kategoriaIstnienia { get; set; } = OT_KatIstnienia.eksploatowany;

        /// <summary>
        /// Pobiera lub ustawia uwagi dotyczące obiektu.
        /// </summary>
        public string? uwagi { get; set; } = null;

        /// <summary>
        /// Pobiera lub ustawia dodatkowe informacje o obiekcie.
        /// </summary>
        public string? informacjaDodatkowa { get; set; } = null;

        /// <summary>
        /// Pobiera lub ustawia kod kartograficzny dla mapy w skali 1:10 000.
        /// </summary>
        public string? kodKarto10k { get; set; } = null;

        /// <summary>
        /// Pobiera lub ustawia kod kartograficzny dla mapy w skali 1:250 000.
        /// </summary>
        public string? kodKarto250k { get; set; } = null;

        /// <summary>
        /// Pobiera lub ustawia skrót kartograficzny obiektu.
        /// </summary>
        public string? skrotKartograficzny { get; set; } = null;

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="OT_ObiektTopograficzny"/>.
        /// </summary>
        public OT_ObiektTopograficzny()
        {
        }
    }
}