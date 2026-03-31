namespace Extensions;

public static class DateOnlyExtension
{
    public static int MonthsFrom(this DateOnly date, DateOnly toDate)
    {
        // se as datas forem iguais, retorna 0 dias
        if (date == toDate)
        {
            return 0;
        }
        // diferencia a data maior(mais recente) da data menor(mais antiga)
        var biggerDate = date > toDate ? date : toDate;
        var smallerDate = date < toDate ? date : toDate;
        
        // calcula o numero absoluto de meses das duas datas a partir do ano 0
        var smallerDateMonths = smallerDate.Year * 12 + smallerDate.Month;
        var biggerDateMonths = biggerDate.Year * 12 + biggerDate.Month;
        // calcula a diferenca de meses entre as duas datas
        var monthsDifference =  biggerDateMonths - smallerDateMonths;

        // caso o dia da data mais recente seja menor que o da mais antiga, um mês é retirado da equação
        // pois ainda não passou completamente
        if (biggerDate.Day < smallerDate.Day)
        {
            monthsDifference--;
        }

        return monthsDifference;
    }
}