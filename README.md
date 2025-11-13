# AV1 e AV2

Alunos:
- DANIEL RODRIGUES GUARILHA: 06003391
- MARCELA DE OLIVEIRA MARTINS PEREIRA: 06008491
- RAFAEL PEREIRA LIMA: 06003197

Professor Doutor: André Campos 

Descrição: Trabalho de fundamentos práticos, com implementação dos seguintes itens: 

item 1 — verificador de alfabeto e cadeia em Σ={a,b}
  Objetivo: checar símbolo individual e cadeia completa quanto ao alfabeto.
  Requisitos:
  • Entrada: um símbolo; depois, uma cadeia.
  • Verificação: símbolo ∈ Σ; cadeia ∈ Σ*.
  • Saída: mensagens claras de válido/inválido.

item 2 — classificador T/I/N por JSON
  Objetivo: ler itens de problemas em JSON e classificar como tratável, intratável ou não
  computável.
  Requisitos:
  • Carregar lista embutida em JSON.
  • Perguntar T/I/N para cada item e registrar acertos/erros.
  • Mostrar resumo final.

item 3 — programa de decisão: “termina com ‘b’?”
  Objetivo: decidir se uma cadeia sobre Σ termina com ‘b’ e sempre terminar.
  Requisitos:
  • Pré-condição: cadeia sobre Σ.
  • Regra: caso vazio tratado; decisão sim/não.
  • Saída: “SIM” ou “NAO”.

item 4 — avaliador proposicional básico
  Objetivo: avaliar fórmulas predeterminadas sobre P, Q, R e opcionalmente gerar tabela-
  verdade.
  Requisitos:
  • Entrada: valores de P, Q, R.
  • Menu com ao menos duas fórmulas (ex.: conjunção/disjunção e uma implicação).
  • Opção para imprimir tabela-verdade completa da fórmula escolhida.

item 5 — reconhecedor Σ={a,b}: L_par_a e a b*
  Objetivo: decidir pertencimento a duas linguagens simples por menu.
  Requisitos:
  • Opções: L_par_a e L = { w | w = a b* }.
• Validação do alfabeto antes da decisão.
• Saída: “ACEITA” ou “REJEITA”.

AV2 — decidibilidade, reconhecimento e modelos

item 6 — problema × instância por JSON
Objetivo: classificar frases como problema (P) ou instância (I).
Requisitos:
• Carregar itens de um JSON embutido.
• Perguntar P/I para cada linha.
• Mostrar acertos/erros e total.

item 7 — decidíveis: L_fim_b e L_mult3_b
Objetivo: implementar dois decisores adicionais sobre Σ={a,b}.
Requisitos:
• Opções separadas no menu.
• Cada decisor deve sempre terminar e responder sim/não.

item 8 — reconhecíveis: reconhecedor que pode não terminar
Objetivo: demonstrar um reconhecedor que pode não terminar em alguns casos.
Requisitos:
• Descrever no console qual linguagem pretende reconhecer.
• Implementar execução que pode não finalizar; permitir abortar por limite de passos
configurável.
• Registrar no console quando a execução foi interrompida por limite.

item 9 — detector ingênuo de loop + reflexão
Objetivo: experimentar uma heurística simples para sinalizar potencial laço.
Requisitos:
• Executar um processo discreto passo a passo, lembrar estados e sinalizar repetição.
• Limite de passos configurável.
• Ao final, imprimir breve reflexão no console sobre falsos positivos/negativos.

item 10 — simulador de AFD de casos fixos
Objetivo: simular um AFD pequeno e executar entradas sobre Σ={a,b}.
Requisitos:
• Definir um AFD simples em estrutura de dados no próprio programa.
• Mostrar estado atual a cada símbolo consumido.
• Ao final, indicar aceitação/rejeição.
Observação: na AV2, os cinco itens somam 10 pontos (2,0 cada).