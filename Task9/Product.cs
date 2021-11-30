using System;

public abstract class Product
{
    public abstract string Name {get;}
    public abstract double StorageLifeDays {get;}
    public string storagePlace { get; set; }
    public DateTime DeliveryTimeStamp {get;}
    public bool IsFresh() // у этого метода логика для всех одинаковая, поэтому можно здесь один раз написать, как он будет работать 
    {
        var today = DateTime.Today;
        var difference = DeliveryTimeStamp - today;
        var convertedDifference = difference.TotalDays;
        if (convertedDifference > StorageLifeDays)
        {
            return false;
        }
        return true;
        // 1. взять текущую дату
// 2. отнять от времени доставки
// 3. посмотреть сколько там дней разницы между ними получилось
// 4. если дней больше StorageLifeDays -> значит тухлое, т.е. не свежое -> возвращаем false
// 5. иначе возвращаем true.
    }
}


public class Fish : Product
{
    public override string Name {get;} = "Fish"; // можно nameof(Fish) также сделать
    public override double StorageLifeDays {
        get
        {
            // по заданию, если холодильник, то 20 дней, иначе в 6 раз меньше
            if (storagePlace == "Icebox") return 20; 
            else if (storagePlace == "Showcase") return 20 / 6;
            else throw new ArgumentException(nameof(storagePlace), $"Undefined storage place! - {storagePlace}");
        } 
    }
    public string StoragePlace {get; set;}
    public new DateTime DeliveryTimeStamp {get;}

    public Fish(string storagePlace, DateTime deliveryTimeStamp)
    {
        StoragePlace = storagePlace;
        DeliveryTimeStamp = deliveryTimeStamp;
    }
}

public class Milk : Product
{
    public override string Name { get; } = "Milk";

    public override double StorageLifeDays
    {
        get
        {
            if (storagePlace == "Icebox") return 60;
            else if (storagePlace == "Showcase") return 60 / 6;
            else throw new ArgumentException(nameof(storagePlace), $"Undefined storage place! - {storagePlace}");
        }

    }

    public string StoragePlace { get; set; }
    private new DateTime DeliveryTimeStamp { get; }

    public Milk(string storagePlace, DateTime deliveryTimeStamp)
    {
        StoragePlace = storagePlace;
        DeliveryTimeStamp = deliveryTimeStamp;
    }

    public class Salt : Milk
    {
        public Salt(string storagePlace, DateTime deliveryTimeStamp) : base(storagePlace, deliveryTimeStamp)
        {
        }
    }
}