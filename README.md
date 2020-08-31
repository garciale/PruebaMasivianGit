# PruebaMasivianGit
lista de endpoints

../api/Roulette/GetListOfRoulettesWithState obtiene todas las ruletas y su estado

../api/Roulette/CloseRoulette/id cierra la ruleta y muestra el historial de apuestas

../api/Roulette/OpenRulette/id abre la ruleta del id especificado

../api/Roulette/CreateRoulette crea una nueva ruleta y devulve el id de esta

../api/Bet/MakeBet Realiza una apuesta en el header IdUser como parametro y envio de los datos de la apuesta en en body 
{
        "Id":0,
        "RouletteId":0,
        "Amount" : 500,
        "Color" : "Black",
        "Number" : 23,
        "BetAt" :null
 }

prueba masivian
