from Crypto.PublicKey import RSA
from Crypto.Cipher import PKCS1_OAEP
import binascii
keyPair = RSA.generate(1024)
pubKey = keyPair.publickey()
print(f"Public key: (n={hex(pubKey.n)}, e={hex(pubKey.e)})")
pubKeyPEM = pubKey.exportKey()
print(pubKeyPEM.decode('ascii'))
print(f"Private key: (n={hex(pubKey.n)}, d={hex(keyPair.d)})")
privKeyPEM = keyPair.exportKey()
print(privKeyPEM.decode('ascii'))
#encryption
msg = 'Vaibhav Patel'
encryptor = PKCS1_OAEP.new(pubKey)
encrypted = encryptor.encrypt(bytes(msg,"utf-8"))
print("Encrypted:", binascii.hexlify(encrypted))
