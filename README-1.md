# Ejercicios Expermimentales

Autor: Javier Acosta Portocarrero

En esta parte de la práctica, partiendo de un plano, un cubo y una esfera, realizaré una serie de experimentaciones propuestas. Explicaré los resultados obtenidos para cada uno, junto a un video de la ejecición.

## Supuesto 1

Enunciado: El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody. 

En este caso solo el cubo tiene Rigidbody, así que es el único objeto al que le afecta la física. El plano y la esfera tienen únicamente Collider, por lo que se quedan fijos en su posición. La esfera, al no tener Rigidbody, no cae sobre el cubo aunque esté colocada encima.

Ejecución de este supuesto:
![Gif Supuesto 1](./gifs_readme1/supuesto1.gif)

## Supuesto 2

Enunciado: El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody. 

Ahora tanto el cubo como la esfera tienen Rigidbody. La esfera cae por la gravedad y, como cae casi en el borde del cubo, choca con él y termina cayéndose hacia un lado. Después llega al plano y sigue moviéndose sobre él. El cubo también se mueve un poco por el golpe de la esfera.

Ejecución de este supuesto:
![Gif Supuesto 2](./gifs_readme1/supuesto2.gif)

## Supuesto 3

Enunciado: El plano no es un objeto físico. El cubo es un objeto físico y la esfera es cinemática. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody esta última cinemático. 

La esfera tiene Rigidbody pero está marcada como cinemática. Esto hace que no le afecte la gravedad ni las fuerzas, así que se queda en su posición y no cae sobre el cubo.

Ejecución de este supuesto:
![Gif Supuesto 3](./gifs_readme1/supuesto3.gif)

## Supuesto 4

Enunciado: El plano es un objeto físico. El cubo es un objeto físico y la esfera es física. En este caso, todos los objetos deben tener Rigidbody.

En esta situación los tres objetos tienen Rigidbody, incluido el plano. Como el plano también es físico y no es cinemático, la gravedad le afecta y empieza a caer. Al final tanto el plano como el cubo y la esfera caen exactamente a la misma velocidad, pues tienen la misma masa, por lo que no hay colisiones.

Ejecución de este supuesto:
![Gif Supuesto 4](./gifs_readme1/supuesto4.gif)

## Supuesto 5

Enunciado: El plano es un objeto cinemático. El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody. 

El plano tiene Rigidbody pero es cinemático, por lo que se mantiene fijo y funciona como suelo. La esfera tiene 10 veces más masa que el cubo, así que cuando cae y golpea el borde del cubo se nota más el efecto del choque en el cubo que antes, moviéndolo un poco más.

Ejecución de este supuesto:
![Gif Supuesto 5](./gifs_readme1/supuesto5.gif)

## Supuesto 6

Enunciado: El plano es un objeto cinemático. El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody. 

Es parecido al caso anterior, pero ahora la esfera tiene 100 veces más masa que el cubo. La diferencia de masa es mucho mayor, así que el cubo se ve más afectado por el impacto. La esfera, tras colisionar con el cubo, se desliza mucho más lentamente por el plano.

Ejecución de este supuesto:
![Gif Supuesto 6](./gifs_readme1/supuesto6.gif)

## Supuesto 7

Enunciado: El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con fricción. En este caso, todos los objetos deben tener Rigidbody. 

Todos los objetos son físicos y a la esfera se le añade fricción. En este caso la fricción no se llega a apreciar porque el plano también tiene Rigidbody y cae junto con los demás objetos. Como no hay una superficie estable sobre la que la esfera se deslice durante mucho tiempo, es difícil ver claramente el efecto de la fricción. La fricción se añadió creando un material dísico y añadiéndo este al collider de la esfera.

Ejecución de este supuesto:
![Gif Supuesto 7](./gifs_readme1/supuesto7.gif)

## Supuesto 8

Enunciado: El plano es un objeto cinemático. El cubo es un objeto físico y la esfera no es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody. 

El plano es cinemático, así que se mantiene fijo, y el cubo se comporta de forma física normal. La esfera es un Trigger y no es física, por lo que no cae por la gravedad. Además, al ser Trigger, si otro objeto la atraviesa no se produce un choque físico, simplemente se detectaría que ha entrado en su zona.

Ejecución de este supuesto:
![Gif Supuesto 8](./gifs_readme1/supuesto8.gif)

## Supuesto 9

Enunciado: El plano es un objeto cinemático. El cubo es un objeto físico y la esfera es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody. 

En este caso la esfera también es Trigger, pero a diferencia del anterior sí es física. Por eso la gravedad hace que caiga. Sin embargo, al tener activado Is Trigger, no choca físicamente con el cubo ni con el plano, sino que los atraviesa y continúa cayendo.

Ejecución de este supuesto:
![Gif Supuesto 9](./gifs_readme1/supuesto9.gif)