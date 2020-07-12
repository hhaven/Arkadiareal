using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Awake()
    {
        BuildItemDB();
    }

    public ItemDB GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public ItemDB GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    public ItemDB GetItem(string type)
    {
        return items.Find(item => item.type == type);
    }

    void BuildItemDB()
    {
        items = new List<Item>()
        {
            new Item(1, "Espada", "Espada de con filo",
            new Dictionary<string, int>
            {
                {"Poder", 12 },
                {"Critico", 24}
            }, 10, "Arma"),
            new Item(2, "Espada de fuego", "Daño de fuego a enemigos",
            new Dictionary<string, int>
            {
                {"Poder", 13 },
                {"Critico", 28 }
            }, 20,"Arma"),
            new Item(3, "Espada de diamante", "Espada con mas daño",
            new Dictionary<string, int>
            {
                {"Poder", 20 },
                {"Critico", 40 }
            }, 150, "Arma"),
            new Item(4, "Espada de hielo", "Efecto de congelacion",
            new Dictionary<string, int>
            {
                {"Poder", 16 },
                {"Critico", 32 }
            }, 40, "Arma"),
            new Item(5, "Manzanas", "Restaura un poco de salud",
            new Dictionary<string, int>
            {
                {"Curacion", 10 },
            }, 10, "Salud"),
            new Item(6, "Pocion", "Restaura 25 de vida",
            new Dictionary<string, int>
            {
                {"Curacion", 25 },
            }, 25, "Salud"),
            new Item(7, "Elixir", "Cura la mitad de vida",
            new Dictionary<string, int>
            {
                {"Curacion", 50 },
            }, 45, "Salud"),
            new Item(8, "Armadura Alpha", "Proteccion basica para la aventura",
            new Dictionary<string, int>
            {
                {"Defensa", 10 },
            }, 20, "Armadura"),
            new Item(7, "Armadura Beta", "Eficientes protecciones",
            new Dictionary<string, int>
            {
                {"Defensa ", 25 },
            }, 45, "Armadura"),
            new Item(7, "Armadura Omega", "La mejor armadura del juego",
            new Dictionary<string, int>
            {
                {"Defensa", 55 ,"Armadura"},
            }, 145)
        };
    }

}
