# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

**Objetivos dos testes:**

Analisar o uso do software ÁGILFORNEC <br />
Identificar problemas de usabilidade e propor soluções <br />
Analisar se o software atende às necessidades dos usuários <br />
Melhorar a experiência do usuário com o software

**Estratégia de teste:**

Teste de usabilidade: realizar testes com usuários reais para avaliar a usabilidade do software ÁGILFORNEC atrás vez dos Softwares de tecnicas de ClickStream, com os dados fornecidos pelo Azure Stream Analytics <br />
Observação direta: observar o comportamento do usuário durante os testes para identificar problemas de usabilidade <br />
Formulario: Disponibilizar um formulario no final do teste para coletar feedback adicional sobre a usabilidade do software

**Plano de teste:**

Selecionar um grupo de usuários semelhantes ao público-alvo do software ÁGILFORNEC <br />
Os usuarios beta-tester, teram que realizar uma lista de tarefas específicas que os usuários devem realizar no software <br />
Coletar feedback dos usuários após os testes na realização de um formulario

**Ferramentas de teste:**

Ferramentas para a realização do teste:

Azure Stream Analytics <br />
Azure Data Factory


**Responsabilidades** <br />

Equipe de teste: responsável por selecionar e preparar candidatos e conduzi-los os usuarios passando intruções de atividades<br />
Equipe de desenvolvimento: atra vez dos dados coletados devem propor soluçoes que sejam pertinente aos dados para melhoria de uso do sistema<br />

**Critérios de aceitação:**

Os usuários tem que possuir alguma caracteristicas do publico-alvo para serem considerados validos <br />
Os usuários devem realizar a lista de tarefas designadas a eles <br />
Os usuários devem ser capazes de realizar as tarefas propostas com facilidade e sem ajuda externa <br />
Os usuários devem fornecer feedback sobre a usabilidade do software após os testes.

 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Cadastrar filia ou funcinario	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue Cadastrar filia ou funcinario. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na pagia de cadastro de usuario <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Cadastra produto	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue Cadastrar produto. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na aba "Gerenciar estoque" <br> - Clickar em adicionar Produto |
|Critério de Êxito | - Efetuar cadastro de produto. |
|  	|  	|
| Caso de Teste 	| CT-05 – Adicionar ou remover quantidade do produto	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue Adicionar ou remover a informação da quantidade de produto no estoque. |
| Passos |	- Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na aba "Gerenciar estoque" <br> - Selecionar o produto que deseja alterar <br>- Clickar em adicionar Produto |
|Critério de Êxito | - A quantidade de produto tenha sido alterada para qualquer valor. |
|  	|  	|
| Caso de Teste 	| CT-06 – Buscar produto	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue buscar itens desejados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na aba "Gerenciar estoque" <br> - Preencher o buscador de produto
|Critério de Êxito | - O produto encontrado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-07 – Fazer pedido de reposição	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário Solicitação reposição desejada. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na aba "Gerenciar estoque" <br> - Selecionar o produto que deseja a reposição <br>- Clickar em Solicitar reposição |
|Critério de Êxito | - A solicitação foi realizada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-08 – Gerar dashbord	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar dashbord. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na pagia de "Visualizar Dashbords" <br> - selecionar parametros<br> - Gerar dashbord
|Critério de Êxito | - Dashbord exibido com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-09 – Emitir relatorio	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue Emitir relatorio. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://marvelapp.com/prototype/6ae25ga/screen/91248461<br> -Realizar login <br> - Entrar na pagia de "Visualizar Dashbords" <br> - selecionar parametros<br> - Gerar relatorio
|Critério de Êxito | - Relatorio gerado exibido com sucesso. |





> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
