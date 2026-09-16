classDiagram
    %% Herencia
    Personaje <|-- Mago
    Personaje <|-- Elfo
    Personaje <|-- Enano

    Item <|-- Arma
    Item <|-- Ropaje
    Item <|-- LibroDeHechizos

    Personaje "1" o-- "*" Item : tiene

    LibroDeHechizos "1" *-- "*" Hechizo : contiene

    class Personaje{
        <<abstract>>
        -string nombre
        -int vida
        -int vidaMaxima
        -int ataqueBase
        -int defensaBase
        -List~Item~ items
        #Personaje(string nombre, int vida, int ataqueBase, int defensaBase)
        +AgregarItem(Item item)
        +QuitarItem(Item item)
        +ObtenerAtaqueTotal() int
        +ObtenerDefensaTotal() int
        +RecibirAtaque(int poder)
        +Curar()
        +RealizarAtaque(Personaje objetivo)
        #AumentarAtaqueBase(int cantidad)
        #AumentarDefensaBase(int cantidad)
        +obtenerVida() int
    }

    class Mago{
        +Mago(string nombre)
        +Estudiar()
    }

    class Elfo{
        +Elfo(string nombre)
        +CurarA(Personaje objetivo)
    }

    class Enano{
        +Enano(string nombre)
    }

    class Item{
        <<abstract>>
        -int valorAtaque
        -int valorDefensa
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }

    class Arma{
        +Arma(int valorAtaque)
    }


    class Ropaje{
        +Ropaje(int valorDefensa)
    }

    class LibroDeHechizos{
        -List~Hechizo~ hechizos
        +AgregarHechizo(Hechizo h)
        +QuitarHechizo(Hechizo h)
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }

    class Hechizo{
        -int valorAtaque
        -int valorDefensa
        +Hechizo(int valorAtaque, int valorDefensa)
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }
