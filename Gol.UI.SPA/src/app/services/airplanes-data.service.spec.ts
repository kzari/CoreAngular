import { TestBed } from '@angular/core/testing';

import { AirplanesDataService } from './airplanes-data.service';

describe('AirplanesDataService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AirplanesDataService = TestBed.get(AirplanesDataService);
    expect(service).toBeTruthy();
  });
});
