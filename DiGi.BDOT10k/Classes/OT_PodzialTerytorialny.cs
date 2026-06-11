namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Reprezentuje abstrakcyjną klasę dla obiektów topograficznych należących do podziału terytorialnego.
    /// </summary>
    public abstract class OT_PodzialTerytorialny : OT_ObiektTopograficzny
    {
        /// <summary>
        /// Pobiera lub ustawia nazwę jednostki podziału terytorialnego.
        /// </summary>
        public string nazwa { get; set; } = string.Empty;

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="OT_PodzialTerytorialny"/>.
        /// </summary>
        public OT_PodzialTerytorialny()
        {
        }
    }
}