# ProjetoFCamara
Projeto para teste da FCamara

Json para teste pelo Postman ou Swagger

{
  "ContaOrigem": {
    "numero": 1,
    "nomeTitular": "Cliente A",
    "saldo": 5000
  },
  "ContaDestino": {
    "numero": 2,
    "nomeTitular": "Cliente B",
    "saldo": 5000
  },
  "valor": 2000
}


#Resposta

1-
DDD hoje e um padrão de Projeto  que veio para melhora os processo de desenvolvimento o mesmo visa ajuda as equipes de desenvolvimentos a entender melhor o contexto os projetos onde o mesmo permite a utulização dos conheicmento para tecnico para gera um produto final com a melhor qualidade

2- 
Micro services e uma maneira de desenvolver aplicações onde cada modulo do software seja um serviço standalone cujo o deploy e escala acontecem de maneira independente da aplicação principal.
Os Ganhos estaõ em processamentos e performance das suas rotinas pois as mesmas estaram isoladas com isso tera um maior ganho que as arquiteturas tradicionais  além de facilitar a escalabilidade do sistema, simplificar o deploy de componentes separados do sistema.
Os desafios na implementação dos microservices no meu ponto de vista são: Monitoramento e logs , Automação de infraestrutura caso a empresa esteja iniciando e Service registry e service discovery
Service Registry é uma espécie de database que contém informações sobre a localidade dos serviços na rede, onde toda vez que um serviço sobe, ele ativamente (ou de maneira dinâmcia) informa o servicy registry

3- 
Síncrona: Quando uma requisição é enviada, o processo remetente é bloqueado até que ocorra uma resposta, ou seja, não é possível enviar novas requisições até que nossa requisição atual seja finalizada, existe sincronismo entre as requisições.
Assíncrona :Em uma requisição assíncrona, não existe sincronismo entre as requisições, sendo assim, podemos enviar diversas requisições em paralelo, onde cada resposta retorna quando estiver pronta.
A melhor maneira para usa uma e outra esta relacionada a processamento caso o seu serviços venha ter muitas concorrencia o melhor cenario seria usa o mesmo via Assíncrona  pois não ira gera uma alta demanda da sua infra caso seja um requisão simples sem grande escalabilidade a Síncrona já resolveria o cenario .

