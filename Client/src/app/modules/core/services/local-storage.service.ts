import { Injectable } from '@angular/core';
import { inject } from '@angular/core/testing';
import { EncryptStorage } from 'encrypt-storage';
import { LocalStorageKeys } from '../../shared/models/local-storage-keys.model';
import { User } from '../auth/User';

@Injectable({ providedIn: 'root' })
export class LocalStorageService {
  encryptStorage = new EncryptStorage('street-lighting', {
    storageType: 'localStorage',
  });
  constructor() {}

  get PasswordToken() {
    return this.encryptStorage.getItem(LocalStorageKeys.PasswordToken)!;
  }
  set PasswordToken(passwordToken: string) {
    this.encryptStorage.setItem(LocalStorageKeys.PasswordToken, passwordToken);
  }
  get UserData() {
    return this.encryptStorage.getItem(LocalStorageKeys.UserData)!;
  }
  set UserData(userData: User) {
    this.encryptStorage.setItem(LocalStorageKeys.UserData, userData);
  }
}
