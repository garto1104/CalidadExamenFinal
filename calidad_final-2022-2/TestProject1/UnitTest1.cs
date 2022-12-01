using Calidad20222.web.Models;
using Calidad20222.web.Services;


namespace TestProject1;

public class UnitTest1
{

    [Test]
    public void ReglaPoker()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta { 
                Numero = 5, 
                Palo = "ESPADA"},
            new Carta { 
                Numero = 5, 
                Palo = "COCO"},
            new Carta { 
                Numero = 5, 
                Palo = "CORAZON"},
            new Carta { 
                Numero = 5,
                Palo = "TREBOL"},
            new Carta { 
                Numero = 5, 
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("POKER", result);
    }

    [Test]
    public void ReglaFull()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 1,
                Palo = "COCO"},
            new Carta {
                Numero = 1,
                Palo = "ESPADA"},
            new Carta {
                Numero = 1,
                Palo = "CORAZON"},
            new Carta {
                Numero = 7,
                Palo = "TREBOL"},
            new Carta {
                Numero = 7,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("FULL", result);
    }

    [Test]
    public void ReglaColor()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 1, 
                Palo = "COCO"},
            new Carta { 
                Numero = 11, 
                Palo = "COCO"},
            new Carta { 
                Numero = 8, 
                Palo = "COCO"},
            new Carta { 
                Numero = 5, 
                Palo = "COCO"},
            new Carta { 
                Numero = 7, 
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("COLOR", result);
    }

    [Test]
    public void ReglaEscalera()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 10,
                Palo = "CORAZON"},
            new Carta {
                Numero = 9,
                Palo = "ESPADA"},
            new Carta {
                Numero = 8,
                Palo = "COCO"},
            new Carta {
                Numero = 7,
                Palo = "TREBOL"},
            new Carta {
                Numero = 6,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("ESCALERA", result);
    }

    [Test]
    public void ReglaTrio()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 12,
                Palo = "CORAZON"},
            new Carta {
                Numero = 12,
                Palo = "ESPADA"},
            new Carta {
                Numero = 12,
                Palo = "COCO"},
            new Carta {
                Numero = 7,
                Palo = "TREBOL"},
            new Carta {
                Numero = 6,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("TRIO", result);
    }

    [Test]
    public void ReglaDoblePareja()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 11,
                Palo = "CORAZON"},
            new Carta {
                Numero = 11,
                Palo = "TREBOL"},
            new Carta {
                Numero = 9,
                Palo = "COCO"},
            new Carta {
                Numero = 9,
                Palo = "TREBOL"},
            new Carta {
                Numero = 2,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("DOBLE PAREJA", result);
    }

    [Test]
    public void ReglaDoble()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 12,
                Palo = "ESPADA"},
            new Carta {
                Numero = 12,
                Palo = "CORAZON"},
            new Carta {
                Numero = 6,
                Palo = "CORAZON"},
            new Carta {
                Numero = 9,
                Palo = "TREBOL"},
            new Carta {
                Numero = 2,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("DOBLE", result);
    }

    [Test]
    public void ReglaEscaleraReal()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 1,
                Palo = "ESPADA"},
            new Carta {
                Numero = 13,
                Palo = "ESPADA"},
            new Carta {
                Numero = 12,
                Palo = "ESPADA"},
            new Carta {
                Numero = 11,
                Palo = "ESPADA"},
            new Carta {
                Numero = 10,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("COLOR", result);
    }

    [Test]
    public void ReglaEscaleraColor()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 10,
                Palo = "CORAZON"},
            new Carta {
                Numero = 9,
                Palo = "CORAZON"},
            new Carta {
                Numero = 8,
                Palo = "CORAZON"},
            new Carta {
                Numero = 7,
                Palo = "CORAZON"},
            new Carta {
                Numero = 6,
                Palo = "CORAZON"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("COLOR", result);
    }

    [Test]
    public void ReglaCartaAlta()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 1,
                Palo = "CORAZON"},
            new Carta {
                Numero = 12,
                Palo = "ESPADA"},
            new Carta {
                Numero = 6,
                Palo = "ESPADA"},
            new Carta {
                Numero = 5,
                Palo = "COCO"},
            new Carta {
                Numero = 10,
                Palo = "TREBOL"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("CARTA MAYOR", result);
    }

    [Test]
    public void ReglaPoker02()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 10,
                Palo = "ESPADA"},
            new Carta {
                Numero = 10,
                Palo = "COCO"},
            new Carta {
                Numero = 10,
                Palo = "CORAZON"},
            new Carta {
                Numero = 10,
                Palo = "TREBOL"},
            new Carta {
                Numero = 5,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("POKER", result);
    }

    [Test]
    public void ReglaEscaleraColor02()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 12,
                Palo = "CORAZON"},
            new Carta {
                Numero = 11,
                Palo = "CORAZON"},
            new Carta {
                Numero = 10,
                Palo = "CORAZON"},
            new Carta {
                Numero = 9,
                Palo = "CORAZON"},
            new Carta {
                Numero = 8,
                Palo = "CORAZON"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("COLOR", result);
    }

    [Test]
    public void ReglaEscalera02()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 12,
                Palo = "CORAZON"},
            new Carta {
                Numero = 11,
                Palo = "ESPADA"},
            new Carta {
                Numero = 10,
                Palo = "COCO"},
            new Carta {
                Numero = 9,
                Palo = "TREBOL"},
            new Carta {
                Numero = 8,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("ESCALERA", result);
    }

    [Test]
    public void ReglaDoblePareja02()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 5,
                Palo = "CORAZON"},
            new Carta {
                Numero = 5,
                Palo = "TREBOL"},
            new Carta {
                Numero = 4,
                Palo = "COCO"},
            new Carta {
                Numero = 4,
                Palo = "TREBOL"},
            new Carta {
                Numero = 3,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("DOBLE PAREJA", result);
    }

    [Test]
    public void ReglaTrio02()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 11,
                Palo = "CORAZON"},
            new Carta {
                Numero = 11,
                Palo = "ESPADA"},
            new Carta {
                Numero = 11,
                Palo = "COCO"},
            new Carta {
                Numero = 5,
                Palo = "TREBOL"},
            new Carta {
                Numero = 3,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("TRIO", result);
    }

    [Test]
    public void ReglaFull02()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 5,
                Palo = "COCO"},
            new Carta {
                Numero = 5,
                Palo = "ESPADA"},
            new Carta {
                Numero = 5,
                Palo = "CORAZON"},
            new Carta {
                Numero = 8,
                Palo = "TREBOL"},
            new Carta {
                Numero = 8,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("FULL", result);
    }

    [Test]
    public void ReglaPoker03()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 8,
                Palo = "ESPADA"},
            new Carta {
                Numero = 8,
                Palo = "COCO"},
            new Carta {
                Numero = 8,
                Palo = "CORAZON"},
            new Carta {
                Numero = 8,
                Palo = "TREBOL"},
            new Carta {
                Numero = 5,
                Palo = "COCO"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("POKER", result);
    }

    [Test]
    public void ReglaEscalera03()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 9,
                Palo = "CORAZON"},
            new Carta {
                Numero = 8,
                Palo = "ESPADA"},
            new Carta {
                Numero = 7,
                Palo = "COCO"},
            new Carta {
                Numero = 6,
                Palo = "TREBOL"},
            new Carta {
                Numero = 5,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("ESCALERA", result);
    }

    [Test]
    public void ReglaEscaleraColor03()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 9,
                Palo = "CORAZON"},
            new Carta {
                Numero = 8,
                Palo = "CORAZON"},
            new Carta {
                Numero = 7,
                Palo = "CORAZON"},
            new Carta {
                Numero = 6,
                Palo = "CORAZON"},
            new Carta {
                Numero = 5,
                Palo = "CORAZON"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("COLOR", result);
    }

    [Test]
    public void ReglaTrio03()
    {
        List<Carta> lista = new List<Carta>()
            {
            new Carta {
                Numero = 7,
                Palo = "CORAZON"},
            new Carta {
                Numero = 7,
                Palo = "ESPADA"},
            new Carta {
                Numero = 7,
                Palo = "COCO"},
            new Carta {
                Numero = 4,
                Palo = "TREBOL"},
            new Carta {
                Numero = 2,
                Palo = "ESPADA"}
            };

        var pokerService = new PokerService();
        var result = pokerService.GetJugada(lista);
        Assert.AreEqual("TRIO", result);
    }
}