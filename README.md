# Design Patterns - Factory

Em programação orientada a classes (um estilo de programação orientada a objetos), o padrão **Factory** é um **padrão  criacional** (lida com a criação de objetos) que utiliza de mecanismos para resolver o problema de **criar novos objetos** sem ter que específicar explicitamente o objeto que será criado. Isso é feito chamando um método *factory* que será responsável pela criação do objeto.

Neste exemplo que trazemos para vocês, temos uma classe **CharacterService** que tem como objetivo criar um novo personagem que pode ser um **Knight**, um **Mage**, um **Ranger** ou um **Assassin**. Ela também verífica se o tipo do personagem existe ou não. 
A **CharacterService** faz uso de um dicionário de **ICharacterFactory** que contém a lógica de criação para cada um dos tipos apresentados anteriormente.
