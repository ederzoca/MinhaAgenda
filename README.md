# Questão 01:
A classe MauiProgram é configura e inicializa o aplicativo. Primeiro ela cria o MauiAppBuilder, que
é usado pra construir a aplicação. Ele define o aplicativo principal e adiciona o CommunityToolkit,
que são ferramentas para o desenvolvimento.
Depois, configura as fontes utilizadas no aplicativo (OpenSans Regular e Semibold) e ativa o log de
depuração no modo DEBUG para facilitar a identificação de problemas no desenvolvimento. A principal
função é a injeção de dependências, onde são registrados serviços importantes pro funcionamento do
aplicativo, como o repositório de contatos.
Além disso, a classe registra os casos de uso, responsáveis pela lógica de negócios, como visualizar,
adicionar, editar e apagar contatos, organizando e centralizando a lógica de interação com os dados.
Também são registradas as páginas da interface do usuário, como ContatosPage para exibir os contatos,
EditarContatoPage para editar um contato e AdicionarContatoPage para adicionar um novo.
Esses serviços são registrados como Singletons, garantindo que uma única instância de cada serviço
seja utilizada ao longo de toda a execução do aplicativo. E ao final, o método Build() é chamado
para construir a instância final, com todos os serviços configurados e prontos para uso.
Resumindo, a classe MauiProgram organiza e configura o aplicativo, gerenciando a lógica de negócios,
os dados e a interface de forma centralizada.
