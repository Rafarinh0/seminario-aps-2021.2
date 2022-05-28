class Assinante:

    def __init__(self, publicador = None):
        self.__publicador = publicador
        if publicador:
            publicador.assinar(self)

    def update(self, num):
        print('Recebendo notificacao, atualizando objeto ' + str(num) + '...' + str(self))


class Publicador:

    def __init__(self):
        self._assinantes = []
    
    def assinar(self, assinante):
        self._assinantes.append(assinante)

    def desassinar(self, assinante):
        self._assinantes.remove(assinante)

    def notificar_assinantes(self):
        c=1
        for assinante in self._assinantes:
            assinante.update(c)
            c+=1


pub = Publicador()

as1 = Assinante(pub)
as2 = Assinante()
pub.assinar(as2)

pub.notificar_assinantes()
