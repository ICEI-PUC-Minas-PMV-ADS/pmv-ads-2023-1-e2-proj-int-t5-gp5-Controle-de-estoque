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

Será realizado dois tipos de testes, o teste de unitário e o teste de integração. <br />

| **Caso de Teste** 	| **CT-01 – Teste Unitário** 	|
|:---:	|:---:	|
|	Objetivo da técnica 	| Encontrar falhas de funcionamento dentro de uma pequena parte do sistema funcionando independentedemente do todo. |
| Técnica 	| O teste unitário testa pequenas partes do programa, separademente. Conciste em elaborar métodos que testam outros métodos. |
| Ferramentas Necessárias 	|xUnit, para implementação dos testes de unidade <br />.NET SDK, para execução dos testes criados.|
|Critério de Êxito | Abranger todas as possibilidades de entradas de dados e o sistema deve estar tratando todas as opções possíveis. |
|  	|  	|
| Caso de Teste 	| CT-02 –Teste de Integração	|
|Objetivo da técnica | Verificar se os módulos do sistema funcionam corretamente quando integrados uns com os outros, garantindo que as interfaces entre os módulos estejam funcionando conforme o esperado e que não ocorram erros de comunicação.  |
| Técnica 	| "Big-Bang Integration Testing", em que todos os módulos são integrados ao mesmo tempo e testados juntos.|
| Ferramentas Necessárias 	| Azure DevTest Labs, que permite criar ambientes de teste completos<br />Azure Test Plans, que permite planejar, executar e   rastrear testes.|
|Critério de Êxito | Incluem a detecção de erros de interface, erros de comunicação, problemas de compatibilidade entre os módulos e falhas de integração. Além disso, o teste deve garantir que o sistema integrado esteja em conformidade com os requisitos de negócio e com as expectativas do cliente |

