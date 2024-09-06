import { Injectable } from "@nestjs/common";
import { Package } from "./Package";

@Injectable()
export class PackageService {
  constructor() {}
  async ProcessPacakge(args: string): Promise<Package[]> {
    throw new Error("Not implemented");
  }
}
