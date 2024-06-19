using Npgsql;
using System.Data.Common;
using trpo_test_2.colections;
using trpo_test_2.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Material material = MatereialDataSource.GetByPK(3);
        Zbm zbm = ZbmDatasource.GetAll()[0];
        Building building = BuildingDataSource.GetByZbm(zbm)[0];
        Place place = PlaceDataSource.GetByBuilding(building)[0];
        Console.WriteLine(place);
        Scales scales = ScalesDataSource.GetAll()[0];
        Container container = ContainerDataSource.GetContainer("asd");
        UE ue = new UE(material, place, scales, container, 23, "1123", "square");
        UEDataSource.AddUE(ref ue);
        Console.WriteLine(ue);

    }

    static string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=trpo";
    public static NpgsqlDataSource dataSource;

    static Program()
    {
        dataSource = NpgsqlDataSource.Create(connectionString);
    }
}