namespace Full_GRASP_And_SOLID
{
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}
//Implemente esta clase para aplicar DIP, generando una abstracción,
//para que la clase ConsolePrinter no dependa de la clase recipe,
//sino abstraccion de la clase recipe.