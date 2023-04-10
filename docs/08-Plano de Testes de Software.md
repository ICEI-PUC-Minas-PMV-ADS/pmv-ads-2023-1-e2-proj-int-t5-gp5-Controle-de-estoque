# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="02-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="04-Projeto de Interface.md"> Projeto de Interface</a>

**Objetivos dos testes:**

Analisar o uso do software ÁGILFORNEC <br />
Garantir a confiabilidade e a segurança do sistema <br />
Analisar se o software atende às necessidades dos usuários <br />
Melhorar a experiência do usuário com o software

**O Sistema AgilFornec**

Este projeto tem como objetivo conseguir administar estoque de uma empresa e de suas filiais espalhadas por várias regiões. <br />
Para atingir esse propósito esta ferramenta irá criar e administrar um banco de dados que possibiltará armazenar informações necessárias <br />
para o controle de estoque.

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


























Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
