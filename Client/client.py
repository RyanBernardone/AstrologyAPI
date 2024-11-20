import requests

BASE_URL = "http://localhost:5034/astrology"

def register_user():
    nickname = input("Coloque seu nickname: ")
    signo = input("Coloque seu signo do zodiaco: ")
    plano = input("Escolha seu plano (básico/avançado): ")

    response = requests.post(f"{BASE_URL}/register", json={
        "nickname": nickname,
        "signo": signo,
        "plano": plano
    })
    if response.status_code == 200:
        print("Cadastrado com sucesso!")
    else:
        print("Error:", response.text)

def get_horoscope():
    nickname = input("Coloque seu nickname: ")

    response = requests.get(f"{BASE_URL}/horoscope", params={"nickname": nickname})
    if response.status_code == 200:
        data = response.json()
        print("Horoscope Message:", data["mensagem"])
        if "numero_da_sorte" in data:
            print("Lucky Number:", data["numero_da_sorte"])
    else:
        print("Error:", response.text)

def main():
    while True:
        print("\nMenu:")
        print("1. Registrar")
        print("2. Ler Horoscopo")
        print("3. Sair")
        choice = input("Escolha uma opção: ")

        if choice == "1":
            register_user()
        elif choice == "2":
            get_horoscope()
        elif choice == "3":
            break
        else:
            print("Opção Inválida.")

if __name__ == "__main__":
    main()