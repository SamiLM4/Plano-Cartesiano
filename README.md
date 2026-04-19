# Projeto 1° bimestre - Introdução a Computação Gráfica
# 🎨 Projeto de Desenho em C# (WinForms)


<img width="1514" height="799" alt="image" src="https://github.com/user-attachments/assets/dbb56099-4b37-483b-85d2-86e8389f9409" />

<img width="1514" height="799" alt="image" src="https://github.com/user-attachments/assets/cc55a810-ee30-4be6-9c42-ce55c3376ff2" />

Este é um projeto desenvolvido em **C# Windows Forms** que permite desenhar **linhas e retângulos** em um painel, além de aplicar diferentes estilos de linha e calcular propriedades geométricas.

---

## 📌 Funcionalidades

- ✏️ Desenho de **linhas** com dois cliques do mouse  
- 🔲 Desenho de **retângulos** com base em largura e altura  
- 📏 Cálculo da **equação da reta (f(x))**  
- 📐 Cálculo da **distância entre dois pontos**  
- 🎨 Escolha de estilos de linha:
  - Sólido
  - Tracejado
  - Pontilhado
  - Traços personalizados  
- 📊 Controle de **espessura da linha**

---

## 🖱️ Como usar

### 🔹 Desenhar uma linha
1. Clique uma vez no painel para definir o ponto inicial  
2. Clique novamente para definir o ponto final  
3. A linha será desenhada automaticamente  

---

### 🔹 Desenhar um retângulo
1. Defina o ponto inicial clicando no painel  
2. Informe largura e altura nos campos de texto  
3. Clique no botão de desenhar retângulo  

---

### 🔹 Alterar estilo da linha
Use o **ComboBox** para escolher o tipo de linha antes de desenhar.

---

## 📊 Informações exibidas

Ao desenhar uma linha, o sistema mostra:

- 📈 Equação da reta (`f(x) = mx + b`)
- 📏 Distância entre os pontos em pixels

---

## 🛠️ Tecnologias utilizadas

- C# (.NET Windows Forms)
- System.Drawing
- GDI+ (Graphics)

---

## 📁 Estrutura do projeto

- `Form1.cs` → Lógica principal do desenho  
- `panel2` → Área onde os desenhos são feitos  
- `ComboBox` → Escolha de estilo da linha  
- `TextBox` → Entrada de tamanho do retângulo  

---

## 🎯 Objetivo

Projeto desenvolvido para praticar:

- Manipulação de eventos de mouse  
- Desenho gráfico com GDI+  
- Geometria básica aplicada  
- Interface gráfica no Windows Forms  

---

## 👨‍🎓 Autor

- Murilo Gonçalves de Lima  
- Curso Técnico em Informática – 2H  
- Univap / Colégio Técnico Antônio Teixeira Fernandes  

---

## 🚀 Possíveis melhorias futuras

- Desenhar múltiplas formas simultaneamente  
- Ferramenta de mover objetos  
- Salvamento de imagem (PNG)  
- Sistema de "undo/redo"  
- Suporte a círculos e polígonos  
