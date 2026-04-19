# 📈 Projeto de Gráfico Linear em C# (WinForms)

Projeto feito em C# Windows Forms para desenhar uma reta em um plano cartesiano a partir de uma função do 1º grau.

---

<img width="1920" height="1032" alt="image" src="https://github.com/user-attachments/assets/56ce1ab7-0e26-4d95-bf5f-6684c76e3d4a" />


## 📌 O que o projeto faz

- Desenha um plano cartesiano (eixos X e Y)
- Plota uma reta baseada na função:
  f(x) = mx + b
- Permite informar valores de:
  - m (inclinação)
  - b (posição no eixo Y)
  - x1 e x2 (intervalo da reta)
- Atualiza o gráfico ao clicar no botão e ao redimensionar a janela

---

## 🧠 Como funciona

O programa calcula dois pontos da reta:

- y1 = m * x1 + b  
- y2 = m * x2 + b  

Depois desenha a linha entre esses pontos no plano cartesiano.

---

## 🖱️ Como usar

1. Digite os valores de m, b, x1 e x2 nos campos
2. Clique no botão para gerar o gráfico
3. A reta será desenhada na tela

---

## 🛠️ Tecnologias

- C# Windows Forms
- System.Drawing (GDI+)

---

## 🎯 Objetivo

Projeto feito para praticar:

- Função do 1º grau
- Plano cartesiano
- Desenho gráfico no WinForms
